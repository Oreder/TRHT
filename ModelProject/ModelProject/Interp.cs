using System;

namespace ModelProject
{
    class Interp
    {
        private static int FindIndex(double value, double[] array)
        {
            int i = 0;
            while (value >= array[i] && i < array.Length)
                i++;
            return i - 1;
        }

        private static double linear_interp(double x, double x0, double x1, double y0, double y1)
        {
            return ((x1 - x) * y0 + (x - x0) * y1) / (x1 - x0);
        }

        private static double logarithm_interp(double x, double x0, double x1, double y0, double y1)
        {
            try
            {
                double _x = Math.Log(x),
                       _x0 = Math.Log(x0), _x1 = Math.Log(x1),
                       _y0 = Math.Log(y0), _y1 = Math.Log(y1);
                return Math.Exp(linear_interp(_x, _x0, _x1, _y0, _y1));
            }
            catch { }
            return linear_interp(x, x0, x1, y0, y1);
        }

        public static double Lerp(double x, double[] X, double[] Y)
        {
            try
            {
                int i = FindIndex(x, X);
                if (Math.Abs(x - X[0]) < 1E-5)
                    return Y[0];
                return logarithm_interp(x, X[i], X[i + 1], Y[i], Y[i + 1]);
            }
            catch { }
            return Double.NaN;
        }
    }
}
