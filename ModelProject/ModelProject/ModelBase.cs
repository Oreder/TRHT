using System;
using System.IO;
using System.Linq;
using System.Globalization;

namespace ModelProject
{
    class ModelBase
    {
        /// <summary>
        /// Lowest temperature [K]
        /// </summary>
        public static readonly double Tw = 2000.0;
        /// <summary>
        /// PI number
        /// </summary>
        public static readonly double PI = Math.PI;
        /// <summary>
        /// Planck constant [J.s]
        /// </summary>
        public static readonly double Hp = 6.6260704E-34;
        /// <summary>
        /// Speed of light in vacuum [cm/s]
        /// </summary>
        public static readonly double Ch = 3.0E+10;
        /// <summary>
        /// Boltzmann constant [J/K]
        /// </summary>
        public static readonly double Kh = 1.3806485279E-23;
        
        /// <summary>
        /// Current constant helper
        /// </summary>
        private static readonly double C0 = 8.0 * PI * Hp * 1.0E+30;
        /// <summary>
        /// Voltage constant helper
        /// </summary>
        private static readonly double C2 = Hp * 1.0E+15 / Kh;

        /// <summary>
        /// Current
        /// </summary>
        /// <param name="tf"></param>
        /// <param name="freq"></param>
        /// <param name="dfreq"></param>
        /// <returns></returns>
        public static double __Ip(double tf, double freq, double dfreq) =>
            __Up(tf, freq, dfreq) / (4.0 * PI);

        /// <summary>
        /// Voltage
        /// </summary>
        /// <param name="tf"></param>
        /// <param name="freq"></param>
        /// <param name="dfreq"></param>
        /// <returns></returns>
        public static double __Up(double tf, double freq, double dfreq)
        {
            double v0 = C0 * dfreq * Math.Pow((freq / 3.0), 3.0);
            double v1 = Math.Exp(C2 * freq / tf) - 1.0;

            return v0 / v1;
        }

        /// <summary>
        /// Temperature, identifying by radius
        /// </summary>
        /// <param name="z"></param>
        /// <returns></returns>
        public static double GetTemperature(double z, double T0, double m)
        {
            return T0 + (Tw - T0) * Math.Pow(z, m);
        }

        public int NFreq { get; set; }
        public int NTemp { get; set; }

        public double[] Frequency { get; }
        public double[] Temperature;
        public double[,] KFT;

        public ModelBase()
        {
            // size (if need, edit here!)
            NFreq = 193;
            NTemp = 16;

            //Frequency = new double[NFreq + 1];
            //Temperature = new double[NTemp];
            KFT = new double[NFreq, NTemp];

            // read temperature
            Temperature = File.ReadAllText(@"..//..//source//temperature.txt")
                            .Split()
                            .Where(n => !string.IsNullOrWhiteSpace(n))
                            .Select(n => double.Parse(n, CultureInfo.InvariantCulture))
                            .ToArray();

            // read frequency
            Frequency = File.ReadAllText(@"..//..//source//frequency.txt")
                            .Split()
                            .Where(n => !string.IsNullOrWhiteSpace(n))
                            .Select(n => double.Parse(n, CultureInfo.InvariantCulture))
                            .ToArray();
            
            // read KFT
            var list = File.ReadAllText(@"..//..//source//TK.txt")
                            .Split()
                            .Where(n => !string.IsNullOrWhiteSpace(n))
                            .Select(n => double.Parse(n, CultureInfo.InvariantCulture))
                            .ToArray();
            for (int i = 0; i < NTemp; i++)
                for (int j = 0; j < NFreq; j++)
                    KFT[j, i] = list[i * NFreq + j];
        }
    }
}
