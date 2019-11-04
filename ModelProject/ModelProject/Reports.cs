namespace ModelProject
{
    class Reports
    {
        public static void GetTempDiverg(int __NZ, double Radius)
        {
            // initialize
            double M0 = 8.0;
            double T0 = 8000, T1 = 16000;
            int maxStep = (int)((T1 - T0) / 1000);
            double hPos = 1.0 / __NZ;

            // main process
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"..//..//Operator//Report.csv"))
            {
                for (int i = 8; i <= maxStep; i++)
                {
                    // init part
                    T0 = 16000.0;
                    double[] temp = new double[__NZ + 1];
                    double[] divF = new double[__NZ + 1];

                    var sc = new SchemeSolution(__NZ, T0, M0, Radius);
                    sc.MScheme = 0.5;       // Default

                    for (int k = 0; k <= __NZ; k++)
                    {
                        // temperature
                        double currentPosition = k * hPos;
                        temp[k] = ModelBase.GetTemperature(currentPosition, T0, M0);
                    }

                    for (int j = 0; j < sc.NFreq; j++)
                    {
                        // diverigence
                        sc.Solve(j);
                        for (int k = 0; k <= __NZ; k++)
                        {
                            divF[k] += sc.DivF[k] * sc.dFreq;
                        }
                    }

                    for (int j = 0; j <= __NZ; j++)
                    {
                        // save reports
                        file.WriteLine("{0:F3},{1:F3},{2:E}", (double)j/__NZ, temp[j], divF[j]);
                    }

                    // remove part
                    sc = null;
                    temp = null;
                    divF = null;
                }
            }
        }
    }
}
