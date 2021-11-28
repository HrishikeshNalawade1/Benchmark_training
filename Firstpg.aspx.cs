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

    protected void Button1_Click(object sender, EventArgs e)
    {
        string Fname = txtFnme.Text;
        string Lname = txtLnme.Text;
        string Uname = txtUnme.Text;
        string Paswrd = txtPwd.Text;
        string Adres = txtAdrs.Text;
        string Stat = txtSta.Text;
      
        string DoB = txtDob.Text;
        string Remark = txtRmk.Text;
        
        DAL d = new DAL();
        bool res=d.Insert(Fname, Lname, Uname, Paswrd, Adres, Stat, DoB, Remark);
        if(res==true)
        {
            lblMessage.Text = "Insertion sucessfull";
            txtFnme.Text = "";
            txtLnme.Text = "";
            txtUnme.Text = "";
            txtPwd.Text = "";
            txtAdrs.Text = "";
            txtSta.Text = "";
            
            txtDob.Text = "";
            txtRmk.Text = "";
        }
        else
        {
            lblMessage.Text = "Error(Insertion failed)";
        }
    }
}
