using System;

namespace Assignment5
{
    class Employe
    {
        public string name;
        public int age;
        public Employe(int age, string name)
        {
            this.name = name;
            this.age = age;

        }
    }
    class permanent :Employe
    {
        public int emp_id;
        public int emp_salary;

        public permanent(int id, int salary, string name, int age) : base(age, name)
        {
            emp_id = id;
            emp_salary = salary;
        }
        public void PrintEmployee()
        {
            Console.WriteLine("Emp ID:      " + emp_id);
            Console.WriteLine("Emp Name:    " + name);
            Console.WriteLine("Emp Salary:  " + emp_salary);
            Console.WriteLine("Emp Age:     " + age);
            Console.WriteLine("\n\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            permanent E = new permanent(101, 70000, "Hrishi", 24);
            E.PrintEmployee();
        }
    }
}
