namespace Newton___Horner
{
    public class Newton
    {
        /// <summary>
        /// iterative process that can approximate solutions
        /// </summary>
        /// <param Array of the coefficients="coeff"></param>
        /// <param start value="x0"></param>
        /// <param max ammount of iterations="maxIt"></param>
        /// <param epsilon="eps"></param>
        /// <returns></returns>
        public double calculate(double[] coeff, double x0, int maxIt = 10000, double eps = 1e-3)
        {
            Polynom polynom = new Polynom();

            // calculating our first xn to continue with approximation
            double xn = x0 - polynom.fx(coeff, x0) / polynom.dfx(coeff, x0);

            // exception if the derivate dfx equals 0
            if (polynom.dfx(coeff, x0) == 0)
            {
                throw new Exception("You cant divide by Zero");
            }

            // approximation method
            for (int i = 0; i <= maxIt; i++)
            {
                xn = xn - polynom.fx(coeff, xn) / polynom.dfx(coeff, xn);

                // exception
                if (polynom.dfx(coeff, xn) == 0)
                {
                    throw new Exception("You cant divide by Zero");
                }

                // if the result equals the last result in the given epsilon it breaks the approximation
                if (Math.Abs(polynom.fx(coeff, xn)) < eps)
                {
                    break;
                }

                // if the max ammount of iterations is reached
                else if (i == maxIt)
                {
                    // Console.WriteLine("max ammount of iterations reached");
                    // Console.WriteLine("Either you have no root or your x0 is too far from the root");
                }

            }
            // Console.WriteLine("Root: " + xn);
            // Console.WriteLine("-------------");
            return xn;
        }
    }
}
