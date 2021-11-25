using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DisconAr
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int choice;
                 char ch;
                
                SqlConnection con = new SqlConnection("Server=.;Database=Class;trusted_connection=true");
                SqlCommand cmd = new SqlCommand("Select * from Course",con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Course");
                DataTable tab = ds.Tables["Course"];

                do
                {
                    Console.WriteLine("Menue");
                    Console.WriteLine("1.Print All Course");
                    Console.WriteLine("2 Print Course based on CourseId");
                    Console.WriteLine("3.Insert Coursr Details");
                    Console.WriteLine("4.Update Couser Deatails");
                    Console.WriteLine("5.Delete Couser Deatails");
                    Console.WriteLine("Enter your choice");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            foreach (DataRow row in tab.Rows)
                            {
                                Console.WriteLine(row[0].ToString() + "/" + row[1].ToString() + "/" + row[2].ToString() + "/" + row[3].ToString());
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter Course Id");
                            int Cid = Convert.ToInt32(Console.ReadLine());
                  /*error*/    DataRow[] rows = tab.Select("Cid="+Cid);
                           
                            Console.WriteLine("Course Details are");
                            foreach (DataRow row in rows)
                            {
                                Console.WriteLine(row[0].ToString() + "/" + row[1].ToString() + "/" + row[2].ToString() + "/" + row[3].ToString());
                            }
                            break;

                        case 3:
                            Console.WriteLine("Enter Course Id");
                            int Cid1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Couser name");
                            string Cname1 = Console.ReadLine();
                            Console.WriteLine("Enter Teacher name");
                            string Tname1 = Console.ReadLine();
                            Console.WriteLine("Enter Fees");
                            int Fees1 = Convert.ToInt32(Console.ReadLine());


                            DataRow NewRow = tab.NewRow();
                            NewRow["Cid"] = Cid1;
                            NewRow["Cname"] = Cname1;
                            NewRow["Tname"] = Tname1;
                            NewRow["Fees"] = Fees1;
                            tab.Rows.Add(NewRow);
                            adapter.Update(tab);
                            Console.WriteLine("Record Inserted into Table");
                            break;


                        case 4:
                            Console.WriteLine("Enter Course Id");
                            int cid2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Couser name");
                            string Cname2 =Console.ReadLine();
                            Console.WriteLine("Enter Teacher name");
                            string Tname2 =Console.ReadLine();
                            Console.WriteLine("Enter Fees");
                            int Fees2 =Convert.ToInt32(Console.ReadLine());
                           
                      /*error*/      DataRow[] ro = tab.Select("Cid="+cid2);

                            DataRow rowup = ro[0];
                            rowup["Cname"] = Cname2;
                            rowup["Tname"] = Tname2;
                            rowup["Fees"] = Fees2;
                            
                            adapter.Update(tab);
                            Console.WriteLine("Record updated into table");
                            break;



                        case 5:
                            Console.WriteLine("Enter Course Id");
                            int Cid3 = Convert.ToInt32(Console.ReadLine());

                            DataRow[] rod = tab.Select("Cid"+Cid3);
                            DataRow rowdelet = rod[0];
                            tab.Rows.Remove(rowdelet);
                            adapter.Update(tab);
                            Console.WriteLine("Record deleted");
                            break;
                        default:
                            break;
                       
                           
                    }
                    Console.WriteLine("Enter Y to Continue");
                    ch = Convert.ToChar(Console.ReadLine());

                } while (ch=='y'||ch=='Y');

            }
            catch(SqlException sq)
            {
                Console.WriteLine("Error "+sq.Message);
            }
            }
    }
}
