using System;
using System.IO;
using System.Text;
namespace fileIO1
{
    class Program
    {/*Have some issue with this*/
        static void Main(string[] args)
        {
            try
            {
                FileStream fs = new FileStream("C:\\Users\\Hrishikesh\\source\\hii", FileMode.OpenOrCreate,FileAccess.ReadWrite);
                for (int i = 0; i <=10; i++)
                {
                    fs.WriteByte((byte)i);
                }
                fs.Flush();
                Console.WriteLine("Data Copied into file");
                fs.Position = 0;
                for (int i = 0; i <=10; i++)
                {
                    Console.WriteLine((int)fs.ReadByte());
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
