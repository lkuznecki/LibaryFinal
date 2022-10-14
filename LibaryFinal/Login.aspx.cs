using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibaryFinal
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="Bibliotekarz" && txtPassword.Text == "ksiazki")
            {
                Response.Redirect("Dodaj.aspx");
            }
            else
            {

            }
        }
    }
}