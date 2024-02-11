using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FebSect4Prj
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible=false;
        }

        protected void LoginView1_ViewChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            if ((TextBox1.Text == "ram") && (TextBox2.Text == "ram123"))
            {
                FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, true);

            }
            else
            {
                Label1.Text = "invalid";
            }
        }
    }
}