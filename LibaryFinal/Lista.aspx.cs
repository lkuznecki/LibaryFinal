﻿using System;
using Baza;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibaryFinal
{
    public partial class Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GVList.DataSource = MethodClass.BooksDTOs();
            GVList.DataBind();
        }
    }
}