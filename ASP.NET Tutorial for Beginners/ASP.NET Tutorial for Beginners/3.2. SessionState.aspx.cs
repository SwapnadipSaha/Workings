using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDotNET_Tutorial_for_Beginners
{
    public partial class SessionState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Clicks"] is null)
                {
                    Session["Clicks"] = 0;
                }
                TextBox1.Text = Session["Clicks"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ClicksCount = (int)Session["Clicks"] + 1;
            TextBox1.Text = ClicksCount.ToString();
            Session["Clicks"] = ClicksCount;
        }
    }
}