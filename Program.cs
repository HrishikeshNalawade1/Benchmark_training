using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fno = 0,sno=1,res=0;
            Console.WriteLine("Enter number till you want to print fibbonacci series");
            int ch = Convert.ToInt32(Console.ReadLine());
            Console.Write(fno+" "+sno);
            for (int i = 2; i < ch; i++)            
            {
                res = fno + sno;
                Console.Write(res+" ");
                fno = sno;
                sno = res;
            }
        }
    }
}
