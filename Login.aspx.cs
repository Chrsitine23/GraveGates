﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GraveGates
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void OnLogin(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Response.Redirect("~/Home.aspx");
            }
        }   
    }
}