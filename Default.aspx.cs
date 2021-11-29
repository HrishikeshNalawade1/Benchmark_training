using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

   

    protected void TextBox10_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string Fname = TextBox1.Text;
        string Lname = TextBox2.Text;
        string Uname = TextBox3.Text;
        string Paswrd = TextBox4.Text;
        string Adres = TextBox6.Text;
        string Stat = DropDownList1.Text;
      
        string DoB = TextBox9.Text;
        string Remark = TextBox10.Text;
        
        DAL d = new DAL();
        bool res=d.Insert(Fname, Lname, Uname, Paswrd, Adres, Stat, DoB, Remark);
        if(res==true)
        {
            lblMessage.Text = "Insertion sucessfull";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox6.Text = "";
            DropDownList1.Text = "";


            TextBox9.Text = "";
            TextBox10.Text = "";
        }
        else
        {
            lblMessage.Text = "Error(Insertion failed)";
        }
    }
}