using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Tutorial_for_Beginners
{
    public partial class ViewState : System.Web.UI.Page
    {
        int ClicksCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // This will always 1, as in Page_Load ClicksCount initiates to 0
            ClicksCount = ClicksCount + 1;
            TextBox1.Text = ClicksCount.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //introduction to ViewState
            if (ViewState["Clicks"] != null)
            {
                ClicksCount = (int)ViewState["Clicks"] + 1;
            }
            TextBox1.Text = ClicksCount.ToString();
            ViewState["Clicks"] = ClicksCount;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int ClicksCount1 = Convert.ToInt32(TextBox1.Text) + 1;
            TextBox1.Text = ClicksCount1.ToString();
        }
    }
}