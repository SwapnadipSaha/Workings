﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Tutorial_for_Beginners._9._Mapping.ChildOfMapping
{
    public partial class ChildOfMapping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Server.MapPath("." ) + "<br/>");
            Response.Write(Server.MapPath("..") + "<br/>");
            Response.Write(Server.MapPath("~") + "<br/>");
            Response.Write(Server.MapPath("../..") + "<br/>");

        }
    }
}