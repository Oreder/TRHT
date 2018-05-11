namespace ModelProject
{
    class SchemeSolution : ModelBase
    {
        private int __NZ { get; set; }
        private double[] A, B, C, D;

        private double T0 { get; set; }
        private double M { get; set; }
        private double Radius { get; set; }

        public double MScheme { private get; set; }

        public double[] Z;
        private double[,] Up;
        private double[,] U;
        
        public SchemeSolution(int n, double T0, double m, double rad)
        {
            __NZ = n;
            A = new double[__NZ + 1];
            B = new double[__NZ + 1];
            C = new double[__NZ + 1];
            D = new double[__NZ + 1];

            this.T0 = T0;
            M = m;
            Radius = rad;
        }

        private void Get_Co(double freq, double dfreq, double[] k)
        {
            double h = 1.0 / __NZ;                  // step
            double r3h = 3.0 * Radius * Radius * h * h;

            double t00 = GetTemperature(0.0, T0, M),
                   t01 = GetTemperature(h / 2.0, T0, M),
                   tN1 = GetTemperature(1.0 - h / 2.0, T0, M),
                   tN0 = GetTemperature(1.0, T0, M);
            double k00 = Interp.Lerp(t00, Temperature, k),
                   k01 = Interp.Lerp(t01, Temperature, k),
                   kN1 = Interp.Lerp(tN1, Temperature, k),
                   kN0 = Interp.Lerp(tN0, Temperature, k);
            double u00 = __Up(t00, freq, dfreq),
                   u01 = __Up(t01, freq, dfreq),
                   uN1 = __Up(tN1, freq, dfreq),
                   uN0 = __Up(tN0, freq, dfreq);

            for (int j = 1; j <= __NZ; j++)        /* filling arrays A, C */
            {
                double xf = j * h - h / 2.0;
                double tf = GetTemperature(xf, T0, M);
                double kf = Interp.Lerp(tf, Temperature, k);

                A[j] = xf / kf;
                C[j - 1] = A[j];
            }

            for (int j = 1; j < __NZ; j++)         /* filling arrays B, D */
            {
                double xf = j * h;
                double tf = GetTemperature(xf, T0, M);
                double kf = Interp.Lerp(tf, Temperature, k);
                B[j] = A[j] + C[j] + r3h * xf * kf;

                double Uf = __Up(tf, freq, dfreq);
                D[j] = r3h * xf * kf * Uf;
            }

            A[0] = 0.0;
            C[0] = 8.0 / (r3h * k01) - k01 / 2.0;
            B[0] = A[0] + C[0] + k00 + k01;
            D[0] = k00 * u00 + k01 * u01;

            double alpha = r3h * (2.0 - h / 2.0);
            double beta = Radius * h * (2.0 - h / 2.0);
            A[__NZ] = 8.0 * (1.0 - h / 2.0) / (alpha * kN1) - kN1 / 2.0;
            C[__NZ] = 0.0;
            B[__NZ] = A[__NZ] + C[__NZ] + kN0 + kN1 + (4.0 * MScheme) / beta;
            D[__NZ] = kN1 * uN1 + kN0 * uN0;
        }

        private void Solve_Tridiagonal(double freq, double dfreq, double[] k, out double[] tmp)
        {
            Get_Co(freq, dfreq, k);

            double[] p = new double[__NZ + 1],
                     q = new double[__NZ + 1];

            p[1] = C[0] / B[0];
            q[1] = D[0] / B[0];

            /// Step #1
            for (int j = 1; j < __NZ; j++)
            {
                p[j + 1] = C[j] / (B[j] - A[j] * p[j]);
                q[j + 1] = (D[j] + A[j] * q[j]) / (B[j] - A[j] * p[j]);
            }

            /// Step #2
            tmp = new double[__NZ + 1];
            tmp[__NZ] = (A[__NZ] * q[__NZ] + D[__NZ]) / (B[__NZ] - A[__NZ] * p[__NZ]);
            for (int j = __NZ; j > 0; j--)
            {
                tmp[j - 1] = p[j] * tmp[j] + q[j];
            }

            p = null;
            q = null;
        }

        public void Solve()
        {
            // get base data
            var modelBase = new ModelBase();

            Z = new double[__NZ + 1];
            Up = new double[NFreq, __NZ + 1];
            U = new double[NFreq, __NZ + 1];

            for (int index = 0; index < NFreq; index++)
            {
                double freq = (Frequency[index + 1] + Frequency[index]) / 2.0;
                double dfreq = Frequency[index + 1] - Frequency[index];

                double[] __kFT = new double[NTemp];
                for (int k = 0; k < NTemp; k++)
                    __kFT[k] = KFT[index, k];

                Solve_Tridiagonal(freq, dfreq, __kFT, out double[] tmp);
                for (int j = 0; j <= __NZ; j++)
                    U[index, j] = tmp[j];
                __kFT = null;
            }
            
            double dz = 1.0 / __NZ;
            for (int iz = 0; iz <= __NZ; iz++)
            {
                Z[iz] = iz * dz;
                double tf = GetTemperature(Z[iz], T0, M);
                for (int index = 0; index < NFreq; index++)
                {
                    double freq = (Frequency[index + 1] + Frequency[index]) / 2.0;
                    double dfreq = Frequency[index + 1] - Frequency[index];

                    Up[index, iz] = __Up(tf, freq, dfreq);
                }
            }
        }

        public double[] GetU(int index)
        {
            double[] res = new double[__NZ + 1];
            for (int iz = 0; iz <= __NZ; iz++)
                res[iz] = U[index, iz];
            return res;
        }

        public double[] GetUp(int index)
        {
            double[] res = new double[__NZ + 1];
            for (int iz = 0; iz <= __NZ; iz++)
                res[iz] = Up[index, iz];
            return res;
        }
    }
}