using System;
using Baza;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibaryFinal
{
    public partial class Dodaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlGatunekKsiazki.DataSource = MethodClass.Borrowages();
                ddlGatunekKsiazki.DataBind();
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            MethodClass.Add(txtbImie.Text, txtbNazwisko.Text, Int32.Parse(txtbNrAlbumu.Text), DateTime.Parse(txtbDataW.Text), DateTime.Parse(txtbTerminZ.Text), ddlGatunekKsiazki.SelectedValue, txtbTytul.Text);
        }
    }
}