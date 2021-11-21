using System;

namespace switch1
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of month 1-12 to find out days of it");
        int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("31 Days");
                    break;
                case 2:
                    Console.WriteLine("28 days");
                    break;
                case 3:
                    Console.WriteLine("31 days");
                    break;
                case 4:
                    Console.WriteLine("30 days");
                    break;
                case 5:
                    Console.WriteLine("31 days");
                    break;
                case 6:
                    Console.WriteLine("30 days");
                    break;
                case 7:
                    Console.WriteLine("31 days");
                    break;
                case 8:
                    Console.WriteLine("31 days");
                    break;
                case 9:
                    Console.WriteLine("31 days");
                    break;
                case 10:
                    Console.WriteLine("30 days");
                    break;
                case 11:
                    Console.WriteLine("30 days");
                    break;
                case 12:
                    Console.WriteLine("31 days");
                    break;
                default:
                    Console.WriteLine("Enter correct number");
                    break;
            }
        }
}
}
