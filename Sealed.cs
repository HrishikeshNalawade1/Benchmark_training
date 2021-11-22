using System;

namespace seal
{
   // sealed
   sealed class parent
    {
        public virtual void show()
        {
            Console.WriteLine("This is parent");
        }
    }
   /* class child:parent
    {
        public override void  show ()
        {
            Console.WriteLine("This is child");
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            parent p = new child();
            p.show();
        }
    }
}
