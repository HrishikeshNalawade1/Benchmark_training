using System;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nam,desgi;
            int sal;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nEnter name of employee");
                 nam = Console.ReadLine();
                Console.WriteLine("Enter salary of employee");
                 sal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Designation of Employee");
                 desgi = Console.ReadLine();
                Console.WriteLine("\n"+nam+" "+sal+" "+desgi);
            }
            
        }
    }
}
