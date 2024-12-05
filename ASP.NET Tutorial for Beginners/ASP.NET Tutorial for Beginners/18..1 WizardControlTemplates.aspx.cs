using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Tutorial_for_Beginners
{
    public partial class _18_WizardControlTemplates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button btn = (Button)Wizard1.FindControl("FinishNavigationTemplateContainerID").FindControl("FinishPreviousButton");// this will return a control. We need to convert that into a Button control
            btn.OnClientClick = "return confirm('Are you sure to go to previous step from finish?');";
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (Wizard1.ActiveStepIndex == 0)
            {
                TextBox1.Focus();
            }
            else if (Wizard1.ActiveStepIndex == 1)
            {
                TextBox2.Focus();
            }
            else if (Wizard1.ActiveStepIndex == 2)
            {
                TextBox3.Focus();
            }
        }
    }
}