using System;

namespace Exep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                int num1 = Convert.ToInt32(Console.ReadLine());
                int res = num / num1;
                Console.WriteLine(+res);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
