using System;
using System.IO;

namespace file2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            BinaryWriter writer = null;
            try
            {
                fs = new FileStream("D:\\file\\Hello.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                writer= new BinaryWriter(fs);
                Console.WriteLine("Enter roll no");
                int rollno = Convert.ToInt32(Console.ReadLine());
                writer.Write(rollno);
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                writer.Write(name);
                Console.WriteLine("Enter course");
                string course = Console.ReadLine();
                writer.Write(course);
                writer.Flush();
            }
            catch (IOException io)
            {
                Console.WriteLine("Exception:" + io.Message);
            }
            finally
            {
                writer.Close();
                fs.Close();               
            }

        }
    }
}
