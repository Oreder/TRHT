using System;

namespace ModelProject
{
    class AnalysingCoefficient
    {
        private double[] BaseUE;
        private double[] BaseDF;
        
        public AnalysingCoefficient(double[] _Ue, double[] _divF)
        {
            try
            {
                int size = _Ue.Length;

                BaseUE = new double[size];
                BaseUE = _Ue;

                BaseDF = new double[size];
                BaseDF = _divF;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        /// <summary>
        /// Compare value with beginning point
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool CompareToBase(double value)
        {
            return (BaseUE[0] <= value);
        }

        /// <summary>
        /// Criteria checking equivalent of value in comparision with base
        /// </summary>
        /// <param name="beginValue"></param>
        /// <param name="endValue"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private bool FirstCriteria(double beginValue, double endValue, double begin, double end)
        {
            return (Math.Abs(begin - end) < 1E-9) || (Math.Abs(beginValue * endValue / Math.Pow(BaseUE[0], 2.0)) < 1E-9);
        }

        /// <summary>
        /// Main process: Scheme Solution
        /// </summary>
        /// <param name="scheme"></param>
        /// <param name="index"></param>
        /// <param name="MS"></param>
        /// <returns></returns>
        private double Process(SchemeSolution scheme, int index, double MS)
        {
            scheme.MScheme = MS;
            scheme.Solve(index);
            return scheme.U[0];
        }

        /// <summary>
        /// Analys coefficient m (scheme) by searching beginning point
        /// </summary>
        /// <param name="__NZ"></param>
        /// <param name="T0"></param>
        /// <param name="M"></param>
        /// <param name="Radius"></param>
        /// <param name="index"></param>
        /// <returns>M (scheme) value</returns>
        public double FirstMethod(int __NZ, double T0, double M, double Radius, int index)
        {
            var sc = new SchemeSolution(__NZ, T0, M, Radius);
            
            double begin = 0.0, end = 1000.0, middle = 0.5;
            double beginValue = Process(sc, index, begin),
                   endValue = Process(sc, index, end);

            while (!FirstCriteria(beginValue, endValue, begin, end))
            {
                middle = (begin + end) / 2.0;
                double middleValue = Process(sc, index, middle);

                if (CompareToBase(beginValue) && CompareToBase(middleValue))
                {
                    begin = middle;
                    beginValue = middleValue;
                }
                else
                {
                    end = middle;
                    endValue = middleValue;
                }
            }

            return middle;
        }
    }
}
