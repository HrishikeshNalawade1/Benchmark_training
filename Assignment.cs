using System;

namespace Employee
{
    class Employe
    {
        int empno, sal;
        string ename, designation;
        public void emp(int empno, string ename, int sal,string designation)
        {
            this.empno = empno;
            this.ename = ename;
            this.sal = sal;
            this.designation = designation;
            Console.WriteLine(empno+" "+ename+" "+sal+" "+designation);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employe e = new Employe();
            e.emp(01, "Hrishi", 500000, "maneger");
            Employe e1 = new Employe();
            e1.emp(02,"rahul",50000,"HR");
        }
    }
}
