﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//required for security
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace COMP2007_S2016_Lesson6A
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // use existing session and cookie info
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

            // sign out the logged in user
            authenticationManager.SignOut();

            // Redirect to the Login Page
            Response.Redirect("~/Login.aspx");
        }
    }
}