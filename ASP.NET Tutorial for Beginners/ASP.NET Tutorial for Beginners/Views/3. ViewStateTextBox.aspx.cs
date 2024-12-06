using ASP.NET_Tutorial_for_Beginners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDotNET_Tutorial_for_Beginners
{
    public partial class ViewStateTextBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["Clicks"] is null)
                {
                    ViewState["Clicks"] = 0;
                }
                TextBox1.Text = ViewState["Clicks"].ToString();
            }
            TextBox1.Text = Request.QueryString["ValuePassed"];
            //System.Collections.Specialized.NameValueCollection valueFromNavigation = Request.Form;
            //TextBox1.Text = valueFromNavigation["TextBox1"];

            //Page prevPage = Page.PreviousPage; //In this case, even we pass false, in Server.Transfer, the value will still traverse from one page to another page. Page.PreviousPage property initializes only for Server.Transfer and cross page postbacks. In case of Response.Redirect Page.PreviousPage is null. We will unable to fetch the value. 

            //if (prevPage != null && PreviousPage.IsCrossPagePostBack)
            ////this page can be reached by varities of different ways. Like, we may cross-page post back or type the URL directly and can reached here.Or we can use Response.Redirect, Server.Transfer or Server.Execute etc. If we land in this page by typing the URL dirctly, in that case, the PreviousPage will be null. In that case null.FindControl will throw a nullReferenceException. To avoid run type null exceptions
            //{
            //    TextBox1.Text = ((TextBox)prevPage.FindControl("TextBox1")).Text;

            //Navigation currentPagge =PreviousPage; // this will give an error. as the previous page of thiss page is the base page, i.e. System.Web.UI.Page but we need the previous page of current page i.e. the Navigation page in this case.
            //TextBox1.Text = currentPagge.txtBoxText;
        }

        
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ClicksCount = (int)ViewState["Clicks"] + 1;
            TextBox1.Text = ClicksCount.ToString();
            ViewState["Clicks"] = ClicksCount;
        }
    }
}
