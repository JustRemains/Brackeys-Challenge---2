namespace Brackeys_Challenge___2
{
    internal class Program
    {
        static void Main()
        {
            double num01;
            double num02;

            Console.Write("Input number here: ");

            num01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input number here: ");

            num02 = Convert.ToDouble(Console.ReadLine());

            double result = num01 + num02;

            Console.Write(result);
            
        }
    }
}