using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        if(Txtlogin.Text=="")
        {
            lblerr.ForeColor = Color.Black;
            lblerr.Text = "Please Enter Login Name";
        }
        else if(Txtpass.Text=="")
        {
            lblpass.Text = "Please enter Password";
        }
        else
        {
            string LoginId = Txtlogin.Text;
            string Password = Txtpass.Text;
            DAL d = new DAL();

            if(d.LoginId(LoginId, Password))
            {
                Response.Redirect("FirstForm.aspx");
            }
            else
            {
                lblerr2.ForeColor =Color.Red;
                lblerr2.Text = "Invalid User  name or password";
            }
        }
    }
}
