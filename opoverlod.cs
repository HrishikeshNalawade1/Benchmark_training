using System;

namespace AssignDay2
{
    class students
    {
        int marks;
        public students(int mrk)
        {
            marks = mrk;
            
        }
        public static students operator +(students a, students b)
        {
            students ress = new students(0);
            ress.marks = a.marks + b.marks;
            return ress;
        }
        public static students operator -(students a, students b)
        {
            students ress = new students(0);
            ress.marks = a.marks - b.marks;
            return ress;
        }
        public static students operator *(students a, students b)
        {
            students ress = new students(0);
            ress.marks = a.marks * b.marks;
            return ress;
        }
        public void printmrk()
        {
            Console.WriteLine(marks);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            students s = new students(8);
            students s1 = new students(5);
            students res = s + s1;
            students res1 = s - s1;
            students res2 = s * s1;
            res.printmrk();
            res1.printmrk();
            res2.printmrk();
        }
    }
}
