class Sample
{

    public double Factorial(int number)
    {

        if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1);
        }
    }

    class Program
    {

        static void Main()
        {

            //read number form keyboard
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(System.Console.ReadLine());

            //create object
            Sample s = new Sample();

            //call factorial method
            double fact = s.Factorial(n);

            Console.WriteLine("The Factorial of " + n + " is: " + fact);

            System.Console.ReadKey();

        }
    }
}