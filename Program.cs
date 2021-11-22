using System;

namespace inter
{
    interface iprintable
    {
        public void show();
    }
    class Employe:iprintable
    {
        public void show()
        {
            Console.WriteLine("This is Employee");
        }
    }
    class Account:iprintable
    {
        public void show()
        {
            Console.WriteLine("This is account");
        }
    }
    class Program
    {
        public void CallIprintable(iprintable p)
        {
            p.show();
        }
        static void Main(string[] args)
        {
            Account a = new Account();
            //a.show();
            Employe e = new Employe();
            // e.show();
            Program p = new Program();
            p.CallIprintable(a);
            p.CallIprintable(e);
        }
    }
}
