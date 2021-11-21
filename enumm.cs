using System;

namespace Assignment7
{
    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thrusday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
        
            int myDay = (int)Days.Saturday;
            Console.WriteLine(myDay);
        }
    
    }
}
