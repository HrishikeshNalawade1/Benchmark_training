using System;

namespace Exec1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter elements in array");
            for (int i = 0; i < 7; i++)
            {
                try
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    
                }
            }
        }
    }
}
