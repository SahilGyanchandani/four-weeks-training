namespace FactorialApp
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            long factorial = CalculateFactorial(number);

            Console.WriteLine($"The factorial of {number} is: {factorial}");

            Console.WriteLine("Enter any key to return");
            Console.ReadKey();
        }

        public static long CalculateFactorial(int number)
        {
            //throw new NotImplementedException();
            if (number < 0) throw new ArgumentException();
            long factorial = 1;
            if (number == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                for(int i = 1;i<= number;i++)
                {
                    factorial *= i;
                }

                
            }
            return factorial;


        }
    }
}