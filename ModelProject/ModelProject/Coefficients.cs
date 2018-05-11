using System;

namespace ModelProject
{
    class Coefficients
    {
        private double[] Ue;
        private double[] Us;

        public Coefficients(double[] _Ue, double[] _Us)
        {
            try
            {
                int size = _Ue.Length;

                Ue = new double[size];
                Ue = _Ue;

                Us = new double[size];
                Us = _Us;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public double[] Rel { get; set; }

        public void GetRelation()
        {
            try
            {
                Rel = new double[Ue.Length];
                for (int i = 0; i < Ue.Length; i++)
                    Rel[i] = Us[i] / Ue[i];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
