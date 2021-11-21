using System;

namespace Properties1
{
    public class Employe
    {
        int sal;
        string ename, designation;
        public int Salary
        {
            get
            {
                return sal;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Salary can not be negative");
                sal = value;
            }
        }

        public string empname
        {
            get
            {
                return ename;
            }
            set
            {
                ename = value;
            }
        }
        public string degi
        {
            get
            {
                return designation;
            }
            set
            {
                designation = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employe e = new Employe();
            e.empname = "Hrishikesh";
            e.Salary = 50000;
            e.degi = "HR";
            Console.WriteLine(e.empname+" "+e.Salary+" "+e.degi);
        }
    }
}
