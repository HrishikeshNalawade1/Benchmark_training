using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace EmpProj
{
    class EmployeeDAL
    {
        public SqlDataReader GetEmpData()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                //create a connection
                con = new SqlConnection();
                con.ConnectionString = "Server=.;database=Company;trusted_connection=true";
                con.Open();


                //create a command or pass Stored Procedure
                cmd = new SqlCommand("GetEmpUsingEmpno", con);


                cmd.CommandType = CommandType.StoredProcedure;

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + "\t" + reader[1].ToString() + "\t" + reader[2].ToString() + "\t" + reader[3].ToString() + "\t" + reader[4].ToString());
                }

            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return reader;
        }
        
        public SqlDataReader GtEmpUsingEmpno(String Eno)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                //create a connection
                con = new SqlConnection();
                con.ConnectionString = "Server=.;database=Company;trusted_connection=true";
                con.Open();


                //create a command or pass Stored Procedure
                cmd = new SqlCommand("GtEmpUsingEmpno", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("Eno", Eno);
                cmd.Parameters.Add(param1);


                cmd.CommandType = CommandType.StoredProcedure;

                reader = cmd.ExecuteReader();


            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return reader;
        }
        public int Insert(int Eno, String Ename, int Salary, string Designation, int Depno)
        {

            SqlConnection con = null;
            SqlCommand cmd = null;
            int res=0;
            //Datareader not requierd you are not reading data
            try
            {
                //create a connection
                con = new SqlConnection();
                con.ConnectionString = "Server=.;database=Company;trusted_connection=true";
                con.Open();


                //create a command or pass Stored Procedure
                cmd = new SqlCommand("InsertEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("Eno", Eno);
                SqlParameter param2 = new SqlParameter("Ename", Ename);
                SqlParameter param3 = new SqlParameter("Salary", Salary);
                SqlParameter param4 = new SqlParameter("Designation", Designation);
                SqlParameter param5 = new SqlParameter("Depno", Depno);
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                cmd.Parameters.Add(param3);
                cmd.Parameters.Add(param4);
                cmd.Parameters.Add(param5);
                res =cmd.ExecuteNonQuery();

                
            }
            catch(SqlException ex)
            {
                Console.WriteLine("Error"+ex.Message);
            }
            finally
            {
                con.Close();
            }
            return res;
            }

        public int updateEmp (int Eno, String Ename, int Salary, string Designation, int Depno)
        {

            SqlConnection con = null;
            SqlCommand cmd = null;
            int res = 0;
            //Datareader not requierd you are not reading data
            try
            {
                //create a connection
                con = new SqlConnection();
                con.ConnectionString = "Server=.;database=Company;trusted_connection=true";
                con.Open();


                //create a command or pass Stored Procedure
                cmd = new SqlCommand("updateEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("Eno", Eno);
                SqlParameter param2 = new SqlParameter("Ename", Ename);
                SqlParameter param3 = new SqlParameter("Salary", Salary);
                SqlParameter param4 = new SqlParameter("Designation", Designation);
                SqlParameter param5 = new SqlParameter("Depno", Depno);
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                cmd.Parameters.Add(param3);
                cmd.Parameters.Add(param4);
                cmd.Parameters.Add(param5);
                res = cmd.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return res;
        }
        public void PrintReader(SqlDataReader reader)
        {
            while(reader.Read())
            {
                Console.WriteLine(reader[0]+"\t"+reader[1]+"\t"+reader[2] + "\t"+ reader[3] + "\t" + reader[4]);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            int choice;
            char ch;
            EmployeeDAL dal = new EmployeeDAL();
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Get Details of all Employee");
                Console.WriteLine("2.Get Employee Details Based on Eno");
                Console.WriteLine("3.Insert Employee");
                Console.WriteLine("4.Update Employee");
                Console.WriteLine("5.Delete Employee");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        dal.PrintReader(dal.GetEmpData());
                        break;
                    case 2:
                        Console.WriteLine("Enter Employee number");
                        int empno = Convert.ToInt32(Console.ReadLine());
                        dal.PrintReader(dal.GtEmpUsingEmpno(empno.ToString()));
                        break;
                    case 3:
                        Console.WriteLine("Enter Employee number");
                        int Eno1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee name");
                        string Ename1 = Console.ReadLine();
                        Console.WriteLine("Enter Employee salary");
                        int Salary1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Desigation");
                        string Designation1 = Console.ReadLine();
                        Console.WriteLine("Enter Employee Department");
                        int Depno1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Data Inserted sucessfully");
                        dal.Insert(Eno1, Ename1, Salary1, Designation1, Depno1);
                        //int Eno, String Ename, int Salary, string Designation, int Depno
                        break;

                    case 4:
                        Console.WriteLine("Enter Employee number");
                        int Eno2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee name");
                        string Ename2 = Console.ReadLine();
                        Console.WriteLine("Enter Employee salary");
                        int Salary2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Desigation");
                        string Designation2 = Console.ReadLine();
                        Console.WriteLine("Enter Employee Department");
                        int Depno2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Data Inserted sucessfully");
                        dal.updateEmp(Eno2, Ename2, Salary2, Designation2, Depno2);
                        //int Eno, String Ename, int Salary, string Designation, int Depno
                        break;

                    default:
                        break;
                }
                Console.WriteLine("Presss Y to continue");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch=='Y'||ch=='y');
           

        }


    }
    }

