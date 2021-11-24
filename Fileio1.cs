using System;
using System.IO;
namespace fileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("C:\\Users\\Hrishikesh\\source\\hii");
            if(di.Exists)
            {
                Console.WriteLine(di.FullName);
                Console.WriteLine(di.CreationTime);
                Console.WriteLine(di.Parent);
                Console.WriteLine(di.LastWriteTime);
                FileInfo[] fi = di.GetFiles();
                foreach(FileInfo f in fi)
                {
                    Console.WriteLine(f.FullName);
                    Console.WriteLine(f.Extension);
                    Console.WriteLine(f.CreationTime);
                    Console.WriteLine(f.Length);
                    Console.WriteLine("*******");
                }
            }
            else
            {
                di.Create();
                Console.WriteLine("Directory Creadted");
            }
        }
    }
}
