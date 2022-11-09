namespace Newton___Horner
{
    public class Horner
    {
        /// <summary>
        /// calculating a new array with a root and the coefficients of a polynomial
        /// </summary>
        /// <param return from newton.calculate="root"></param>
        /// <param array of coefficients="coeff"></param>
        /// <returns>new array of coefficients</returns>
        public double[] calculate(double root, double[] coeff)
        {
            double result = 0;
            double[] NewCoeff = new double[coeff.Length - 1];
            double rest = 0;

            // calculate every new coefficient and the rest
            for (int i = 0; i < coeff.Length; i++)
            {
                // the last step is to see if there is a rest (if there is a rest the right one. we always have a rest because the
                // newton method is a approximation method
                if (i == coeff.Length - 1)
                {
                    rest = result * root + coeff[i];
                    break;
                }

                // the first result is the first coefficient
                if (i == 0)
                {
                    result = coeff[i];
                }
                // the results between the first one and the rest
                else
                {
                    result = result * root + coeff[i];
                }
                NewCoeff[i] = result;

            }
            // foreach (double coefficient in NewCoeff) Console.WriteLine(coefficient);

            // Console.WriteLine("Rest:" + rest);

            return NewCoeff;
        }
    }
}
