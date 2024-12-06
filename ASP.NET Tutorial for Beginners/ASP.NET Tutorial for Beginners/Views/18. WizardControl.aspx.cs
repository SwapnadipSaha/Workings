using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Tutorial_for_Beginners
{
    public partial class _18_WizardControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       
                Wizard1.ActiveStepIndex = 1;
        
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {

            if (Wizard1.ActiveStepIndex == 1)
            {
                Wizard1.HeaderText = "Wizard Demo -- Contact";
            };

            if (Wizard1.ActiveStepIndex == 2)
            {
                Wizard1.HeaderText = "Wizard Demo -- Summary";
            };

            if (Wizard1.ActiveStepIndex == 0)
            {
                Wizard1.HeaderText = "Wizard Demo -- Personal";
            };

        }

        protected void Wizard1_NextButtonClick1(object sender, WizardNavigationEventArgs e)
        {
            if (e.NextStepIndex == 2)
            {
                Label1.Text = txtFN.Text;
                Label2.Text = TextBox2.Text;
                Label3.Text = ddlGender.SelectedItem.Text.ToString();
                LblEmail.Text = TextBox3.Text;
                lblMobile.Text = TextBox4.Text;
            }
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Response.Redirect("https://www.google.co.in");
        }

        protected void Wizard1_ActiveStepChanged(object sender, EventArgs e)
        {

        }

        protected void Wizard1_CancelButtonClick(object sender, EventArgs e)
        {

        }

        protected void Wizard1_DataBinding(object sender, EventArgs e)
        {

        }

        protected void Wizard1_Disposed(object sender, EventArgs e)
        {

        }

        protected void Wizard1_Init(object sender, EventArgs e)
        {

        }

        protected void Wizard1_Load(object sender, EventArgs e)
        {

        }

        protected void Wizard1_PreRender(object sender, EventArgs e)
        {

        }

        protected void Wizard1_PreviousButtonClick(object sender, WizardNavigationEventArgs e)
        {

        }

        protected void Wizard1_SideBarButtonClick(object sender, WizardNavigationEventArgs e)
        {

        }
    }
}