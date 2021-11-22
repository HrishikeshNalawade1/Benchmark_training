using System;

namespace AssignmentD3
{
     public abstract class Account
    {
        public int amt;
        public double R, T, SI;

        public abstract void calculateIntrest();
        
    }
    class Saving:Account
    {
        
        public override void calculateIntrest()
        {
            Console.WriteLine("Enter amount to check intrest over saving account");
            amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of intrest");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter years");
            T = Convert.ToDouble(Console.ReadLine());
            SI= (amt*R * T)/ 100;
            Console.WriteLine("Intrest on saving account "+SI);
        }
    }
    class Current:Account
    {
        public override void calculateIntrest()
        {
            Console.WriteLine("Enter amount to check intrest over saving account");
            amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of intrest");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter years");
            T = Convert.ToDouble(Console.ReadLine());
            SI = (amt * R * T) / 100;
            Console.WriteLine("Intrest on Current account  is " + SI);
        }
    }
    class Fd:Account
    {
        public override void calculateIntrest()
        {
            Console.WriteLine("Enter amount to check intrest over Fix Deposite");
            amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of intrest");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter years");
            T = Convert.ToDouble(Console.ReadLine());
            SI = (amt * R * T) / 100;
            Console.WriteLine("Intrest on FD  is " + SI);
        }
    }
    class Program
    {
        public void findinterest(Account a)//Polymorphic argument
        {
            a.calculateIntrest();
        }
        static void Main(string[] args)
        {
            Saving s = new Saving();

            Current C = new Current();

            Fd f = new Fd();


            Program p = new Program();
           // p.findinterest(s);//passing object of class saving
           // p.findinterest(C);//passing obj of call Current
            p.findinterest(f);

        }
    }
}
