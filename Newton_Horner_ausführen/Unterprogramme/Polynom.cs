namespace Newton___Horner
{
    public class Polynom
    {

        /// <summary>
        /// generate the polynomial f(x) with the nessecary parameters
        /// </summary>
        /// <param Array of the coefficients="coefficient"></param>
        /// <param variable="x"></param>
        /// <returns>the result f(x) for a given x</returns>
        public double fx(double[] coefficient, double x)
        {
            double fx = 0;
            for (int n = coefficient.Length - 1; n >= 0; n--)
            {
                fx = fx + coefficient[n] * Math.Pow(x, coefficient.Length - 1 - n);
            }
            return fx;
        }

        /// <summary>
        /// generate the derivative f'(x)
        /// </summary>
        /// <param Array of the coefficients="coefficient"></param>
        /// <param variable="x"></param>
        /// <returns>the result f´(x) for a given x</returns>
        public double dfx(double[] coefficient, double x)
        {
            Array.Reverse(coefficient);

            double dfx = 0;
            for (int n = 0; n < coefficient.Length; n++)
            {
                if (n == 0)
                {
                    dfx = 0;
                }

                else
                {
                    dfx = dfx + coefficient[n] * n * Math.Pow(x, n - 1);
                }
            }
            return dfx;
        }
    }
}
