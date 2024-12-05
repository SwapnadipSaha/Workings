using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDotNET_Tutorial_for_Beginners
{
    public partial class ButtonCommand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void OnCommandButton_Click(object sender, CommandEventArgs e)
        {
            switch(e.CommandName)
            {
                case "Print":
                    Output.Text = "Print Clicked";
                    break;
                case "Delete":
                    Output.Text = "Delete Clicked";
                    break;
                case "Show":
                    if(e.CommandArgument.ToString()== "Top10") { 
                        Output.Text = "Show Top 10 Clicked"; 
                    }
                    if (e.CommandArgument.ToString() == "Bottom10")
                    {
                        Output.Text = "Show Bottom 10 Clicked";
                    }
                    break;
                default:
                    Output.Text = "Nothing Clicked";
                    break;
            }
        }
    }
}