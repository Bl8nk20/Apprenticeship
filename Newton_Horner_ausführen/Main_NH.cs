using Newton___Horner;

public class Program
{
    /// <summary>
    /// starting the programm with the parameters you define as coeff and x0
    /// </summary>
    public static void Main()
    {
        double[] coeff = { 1, 4, -1, -4 };
        double x0 = 2;

        //creating objects to use their methods
        Horner horner = new Horner();
        Newton newton = new Newton();

        // calculate the first root
        double root1 = newton.calculate(coeff, x0);
        // calculate the first new array of coefficients
        double[] NewCoeff = horner.calculate(root1, coeff);

        // repeat the process as long as the polynomial has a root
        for (int i = 1; i < NewCoeff.Length + 1; i++)
        {
            // calculate a root
            double newRoot = newton.calculate(NewCoeff, x0);

            // calculate new coeff
            NewCoeff = horner.calculate(newRoot, NewCoeff);

            // if the new array only contains 2 coefficients 
            if (NewCoeff.Length == 2)
            {
                // Console.WriteLine("There are no more roots.");
            }

            // if the new array is has only 1 number break
            if (NewCoeff.Length == 1)
            {
                break;
            }
        }
    }
}