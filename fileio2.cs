using System;
using System.IO;
namespace FileIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
           //StreamWriter writer = null;
             StreamReader reader = null;
            try
            {
                /*fs = new FileStream("D:\\file\\test.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);
                writer = new StreamWriter(fs);
               Console.WriteLine("Enter Data which need to be stored in file");
               string data = "";
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
               while(data!=null)
               {
                   data = Console.ReadLine();
                   writer.WriteLine(data);
               }
               writer.Flush();
               Console.WriteLine("DataCopied Into File");*/
                fs = new FileStream("D:\\file\\test.txt",FileMode.Open,FileAccess.Read);
                reader = new StreamReader(fs);
                Console.WriteLine("Data into File");
                Console.WriteLine(reader.ReadToEnd());
            }
            catch(IOException io)
            {
                Console.WriteLine("Exception:"+io.Message);
            }
            finally
            {
                reader.Close();
                //writer.Close();
                fs.Close();
                Console.WriteLine("");
            }
        }
    }
}
