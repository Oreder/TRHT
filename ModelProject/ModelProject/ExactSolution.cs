﻿using System;
using System.Collections.Generic;
using System.IO;

namespace ModelProject
{
    class ExactSolution : ModelBase
    {
        private int __nPhi = 60;
        private int __nTheta = 30;

        private int __nZ { get; set; }
        private double T0 { get; set; }
        private double M { get; set; }
        private double Radius { get; set; }

        private double Freq { get; set; }
        private double dFreq { get; set; }
        private double[] __kFT { get; set; }

        public double[] Z;
        public double[] Up;
        public double[] U;
        public double[] K;

        public ExactSolution(int n, double T0, double m, double rad)
        {
            __nZ = n;
            this.T0 = T0;
            M = m;
            Radius = rad;
        }

        /// <summary>
        /// Function F(s, I) as right side in ODE
        /// </summary>
        /// <param name="S0">beginning point</param>
        /// <param name="S">ending point</param>
        /// <param name="I">intensivity</param>
        /// <param name="z">current const axis on surface</param>
        /// <param name="phi">Phi-angle</param>
        /// <param name="theta">Theta-angle</param>        /// <returns></returns>
        private double F(double S0, double S, double I, double z, double phi, double theta)
        {
            double d = (S - S0) * Math.Sin(theta) / Radius;
            double position = Math.Sqrt(z * z + d * d - 2.0 * d * z * Math.Cos(phi));
            double tmp = GetTemperature(position, T0, M);
            double k = Interp.Lerp(tmp, Temperature, __kFT);    // correct?
            double Ip = __Ip(tmp, Freq, dFreq);

            return k * (Ip - I);
        }

        /// <summary>
        /// Applying method Runge-Kutta fourth order to solve I(s, phi, theta)
        /// </summary>
        /// <param name="S0">beginning point</param>
        /// <param name="S">ending point</param>
        /// <param name="I0">beginning intensivity</param>
        /// <param name="N">number chosen points</param>
        /// <param name="z">current const axis on surface</param>
        /// <param name="phi">Phi-angle</param>
        /// <param name="theta">Theta-angle</param>
        /// <returns></returns>
        private double RungeKutta(double S0, double S, double I0, int N, double z, double phi, double theta)
        {
            double h = (S - S0) / N;
            double[] k = new double[4];
            double I = I0;

            for (int round = 0; round < N; round++)
            {
                k[0] = F(S0, S, I, z, phi, theta);

                S0 += h / 2.0;
                k[1] = F(S0, S + h * k[0] / 2.0, I, z, phi, theta);
                k[2] = F(S0, S + h * k[1] / 2.0, I, z, phi, theta);

                S0 += h / 2.0;
                k[3] = F(S0, S + h * k[2], I, z, phi, theta);

                I += (k[0] + 2.0 * k[1] + 2.0 * k[2] + k[3]) * h / 6.0;
            }

            return I;
        }

        /// <summary>
        /// Main solution U(z), Up(z)
        /// </summary>
        /// <param name="index"></param>
        public void Solve(int index)
        {
            // get base data
            var modelBase = new ModelBase();

            Freq = (Frequency[index + 1] + Frequency[index]) / 2.0;
            dFreq = Frequency[index + 1] - Frequency[index];

            __kFT = new double[NTemp];
            for (int k = 0; k < NTemp; k++)
                __kFT[k] = KFT[index, k];

            // initialization
            double dPhi = PI / __nPhi, 
                   dTheta = PI / 2.0 / __nTheta;
            double __sPhi = dPhi / 2.0,
                   __sTheta = dTheta / 2.0;

            double dz = 1.0 / __nZ;
            
            Z = new double[__nZ + 1];
            Up = new double[__nZ + 1];
            U = new double[__nZ + 1];
            K = new double[__nZ + 1];

            // main
            for (int iz = 0; iz <= __nZ; iz++)
            {
                double z = iz * dz;
                Z[iz] = z;

                double tf = GetTemperature(Z[iz], T0, M);
                Up[iz] = __Up(tf, Freq, dFreq);

                K[iz] = Interp.Lerp(tf, Temperature, __kFT);

                U[iz] = 0.0;    // correct?

                for (int i = 0; i < __nPhi; i++)
                {
                    double phi = __sPhi + dPhi * i;

                    for (int j = 0; j < __nTheta; j++)
                    {
                        double theta = __sTheta + dTheta * j;

                        // Calculate length of ray [S0, S]
                        double D = z * Math.Cos(phi) + Math.Sqrt(1.0 - z * z * Math.Sin(phi) * Math.Sin(phi));
                        double S = Radius * D / Math.Sin(theta);

                        // I0 = 0.0 correct?
                        U[iz] += Math.Sin(theta) *
                                 RungeKutta(0.0, S, I0: 0.0, (int)(1.0 / Math.Sin(theta)) + 1, z, phi, theta);
                    }
                }

                U[iz] *= 4.0 * dTheta * dPhi;
            }
        }

        //private double[,] allKj { get; set; }
        //private double[,] allUp { get; set; }
        //private double[,] allUe { get; set; }

        public void SolveAll()
        {
            double[,] allKj = new double[NFreq, __nZ + 1];
            double[,] allUp = new double[NFreq, __nZ + 1];
            double[,] allUe = new double[NFreq, __nZ + 1];

            for (int i = 0; i < NFreq; i++)
            {
                Solve(i);

                for (int j = 0; j <= __nZ; j++)
                {
                    allKj[i, j] = K[j];
                    allUp[i, j] = Up[j];
                    allUe[i, j] = U[j];
                }
            }

            using (StreamWriter file = new StreamWriter(@"..//..//result//All.xlsx"))
            {
                // Kj
                for (int j = 0; j <= __nZ; j++)
                {
                    for (int i = 0; i < NFreq - 1; i++)
                    {
                        file.Write("{0:E}\t", allKj[i, j]);
                    }
                    file.Write("{0:E}\n", allKj[NFreq - 1, j]);
                }

                // Up
                for (int j = 0; j <= __nZ; j++)
                {
                    for (int i = 0; i < NFreq - 1; i++)
                    {
                        file.Write("{0:E}\t", allUp[i, j]);
                    }
                    file.Write("{0:E}\n", allUp[NFreq - 1, j]);
                }

                // U
                for (int j = 0; j <= __nZ; j++)
                {
                    for (int i = 0; i < NFreq - 1; i++)
                    {
                        file.Write("{0:E}\t", allUe[i, j]);
                    }
                    file.Write("{0:E}\n", allUe[NFreq - 1, j]);
                }
            }

            allKj = null;
            allUp = null;
            allUe = null;
        }

        /*
        public void Solve(int index)
        {
            // get base data
            var modelBase = new ModelBase();

            Freq = (Frequency[index + 1] + Frequency[index]) / 2.0;
            dFreq = Frequency[index + 1] - Frequency[index];

            __kFT = new double[NTemp];
            for (int k = 0; k < NTemp; k++)
                __kFT[k] = KFT[index, k];

            // initialization
            double dPhi = PI / __nPhi,
                   dTheta = PI / 2.0 / __nTheta;
            double __sPhi = dPhi / 2.0,
                   __sTheta = dTheta / 2.0;

            double dz = 1.0 / __nZ;

            Z = new double[__nZ + 1];
            Up = new double[__nZ + 1];
            U = new double[__nZ + 1];

            // main
            for (int iz = 0; iz <= __nZ; iz++)
            {
                double z = iz * dz;
                Z[iz] = z;

                double tf = GetTemperature(z, T0, M);
                Up[iz] = __Up(tf, Freq, dFreq);

                U[iz] = 0.0;

                for (int i = 0; i < __nPhi; i++)
                {
                    double phi = __sPhi + dPhi * i;

                    for (int j = 0; j < __nTheta; j++)
                    {
                        double theta = __sTheta + dTheta * j;

                        // Calculate length of ray [S, S0]
                        double D = z * Math.Cos(phi) + Math.Sqrt(1.0 - z * z * Math.Sin(phi) * Math.Sin(phi));
                        
                        // Calculate integral of (k * Ip * exp(-|kdy) * d(x)
                        double result = 0.0;

                        // Choose how many points we need
                        int Nj = (int)(1.0 / Math.Sin(theta)) + 1;
                        double[] kj = new double[Nj + 1];
                        double[] IP = new double[Nj + 1];

                        double dS = Radius / Math.Sin(theta) / Nj;

                        // But first, let prepare all coefficient k
                        for (int jd = 0; jd <= Nj; jd++)
                        {
                            double relation = (double)jd / Nj;
                            double d = (1.0 - relation) * D;
                            double position = Math.Sqrt(z * z + d * d - 2.0 * d * z * Math.Cos(phi));
                            double temp = GetTemperature(position, T0, M);

                            IP[jd] = __Ip(temp, Freq, dFreq);
                            kj[jd] = Interp.Lerp(temp, Temperature, __kFT);
                            //kj[jd] *= (1.0 - Math.Exp(- Hp * Freq * 1E+15 / (Kh * temp)));
                        }

                        // And now calculate our main stuff
                        for (int jd = 0; jd <= Nj; jd++)
                        {
                            double sum = 0.0;
                            for (int jx = jd; jx <= Nj; jx++)
                            {
                                sum += kj[jx];
                            }

                            sum *= D * dS;
                            
                            //Result
                            result += kj[jd] * IP[jd] * Math.Exp(-sum);
                        }

                        // Final
                        U[iz] += result * D * dS * Math.Sin(theta);
                    }
                }

                U[iz] *= 4.0 * dTheta * dPhi;
                //U[iz] = Up[iz] - U[iz];
            }
        }*/
    }
}
