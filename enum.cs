using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr=new string[3];
            Console.WriteLine("Enter Employe name");
            for (int i = 0; i < 3; i++)
            {
                arr[i] = Console.ReadLine();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i+" "+arr[i]);
            }
        }
    }
}
