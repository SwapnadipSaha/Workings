using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Tutorial_for_Beginners
{
    public partial class Navigation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string txtBoxText { 
            get
            { 
                return TextBox1.Text;
            } 
        }
        protected void responseRedirect_command(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "responseRedirect":
                    if (e.CommandArgument == "internal")
                    {
                        Response.Redirect("~/22. DynamicControl.aspx");
                    }
                    else 
                    {
                        Response.Redirect("https://www.google.co.in"); 
                    
                    }
                    break;

                case "serverTransfer":
                    if (e.CommandArgument == "internal")
                    {
                        Server.Transfer("~/3. ViewStateTextBox.aspx",false);//by default  the second parameter is null, i.e. true. If false then the value of the currentpage will not transfer to new page
                        lblServerExecute.Text = "Completed Processiong current page";   // won't come the control here
                    }
                    else
                    {
                        Server.Transfer("https://www.google.co.in");

                    }
                    break;
                case "serverExecute":
                    if (e.CommandArgument == "internal")
                    {
                        Server.Execute("~/3. ViewStateTextBox.aspx", false);//by default  the second parameter is null, i.e. true. If false then the value of the currentpage will not transfer to new page
                        lblServerExecute.Text = "Completed Processiong current page";
                    }
                    else
                    {
                        Server.Execute("https://www.google.co.in");

                    }
                    break;
                //case "CrossPage_PostBack":
                //    if (e.CommandArgument == "internal")
                //    {
                //        Server.Execute("~/3. ViewStateTextBox.aspx");
                        
                //    }
                //    else
                //    {
                //        Server.Execute("https://www.google.co.in");

                //    }
                //    break;
                default:
                    break;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string strJavaScript = "<script>window.open('3. ViewStateTextBox.aspx?ValuePassed=" + TextBox1.Text + "');</script>";
            Response.Write(strJavaScript);
        }
    }
}