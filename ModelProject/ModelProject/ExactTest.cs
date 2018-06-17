using System;

namespace ModelProject
{
    class ExactTest : ModelBase
    {
        private int __nPhi = 60;
        private int __nTheta = 30;

        private int __nZ { get; set; }
        private double T0 { get; set; }
        private double M { get; set; }
        private double Radius { get; set; }

        public double Freq { get; set; }
        private double dFreq { get; set; }
        private double[] __kFT { get; set; }

        public double[] Z;
        public double[] K;
        public double[] Up;
        public double[] U;

        /// <summary>
        /// Divergence
        /// </summary>
        public double[] DivF;

        public ExactTest(int n, double T0, double m, double rad)
        {
            __nZ = n;
            this.T0 = T0;
            M = m;
            Radius = rad;
        }

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

                double tf = GetTemperature(z, T0, M);
                Up[iz] = __Up(tf, Freq, dFreq);

                K[iz] = Interp.Lerp(tf, Temperature, __kFT);

                U[iz] = 0.0;

                for (int i = 0; i < __nPhi; i++)
                {
                    double phi = __sPhi + dPhi * i;

                    for (int j = 0; j < __nTheta; j++)
                    {
                        double theta = __sTheta + dTheta * j;

                        // Calculate length of ray [S0, S]
                        double D = z * Math.Cos(phi) + Math.Sqrt(1.0 - z * z * Math.Sin(phi) * Math.Sin(phi));
                        double S = Radius * D / Math.Sin(theta);

                        // Calculate integral of (k * Ip * exp(-|kdy) * d(x)
                        double result = 0.0;
                        
                        // 1. Choose how many points we need
                        int Nj = (int)(1.0 / Math.Sin(theta)) + 1;

                        // 2. Initialize
                        double[] kj = new double[Nj + 1];
                        double[] IP = new double[Nj + 1];
                        double dS = S / Nj;
                        
                        // 3. Collect all data we need
                        for (int jd = 0; jd <= Nj; jd++)
                        {
                            double posZ = D * (1.0 - (double)jd / Nj);
                            double curZ = Math.Sqrt(z * z + posZ * posZ - 2.0 * posZ * z * Math.Cos(phi));

                            double temp = GetTemperature(curZ, T0, M);
                            IP[jd] = __Ip(temp, Freq, dFreq);
                            kj[jd] = Interp.Lerp(temp, Temperature, __kFT);
                        }

                        // 4. And now calculate our main stuff
                        for (int jd = 0; jd <= Nj; jd++)
                        {
                            // 4.1 the sub-integral
                            double sum = 0.0;
                            for (int jx = jd; jx <= Nj; jx++)
                            {
                                sum += kj[jx];
                            }
                            sum *= dS;

                            // 4.2 Result
                            result += kj[jd] * IP[jd] * Math.Exp(-sum);
                        }

                        kj = null;
                        IP = null;

                        // 5. Final
                        U[iz] += result * dS * Math.Sin(theta);
                    }
                }

                U[iz] *= 4.0 * dTheta * dPhi;
            }

            DivF = new double[__nZ + 1];
            for (int iz = 0; iz <= __nZ; iz++)
            {
                DivF[iz] = Ch * K[iz] * (Up[iz] - U[iz]);
            }
        }
    }
}
