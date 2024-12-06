using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Tutorial_for_Beginners
{
    public partial class MultiView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Multiview1.ActiveViewIndex = 0;    //  The ActiveViewIndex is important, as it will decide to display the view. else, there will be nothing in browser
            }
        }

        protected void ButtonStep2_Click(object sender, EventArgs e)
        {
            Multiview1.ActiveViewIndex = 1;
        }

        protected void ButtonStep1_Click(object sender, EventArgs e)
        {
            Multiview1.ActiveViewIndex = 0;
        }

        protected void ButtonStep3_Click(object sender, EventArgs e)
        {
            Multiview1.ActiveViewIndex = 2;
            Label1.Text = txtFN.Text;
            Label2.Text = TextBox2.Text;
            Label3.Text = ddlGender.SelectedItem.Text;
            LblEmail.Text = TextBox3.Text;
            lblMobile.Text = TextBox4.Text;

            // The controls are in a single webform, but used accrossed different views. Hence the multiview can access all these controls. So this act as multiple page displybg, inside a single page.
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.google.co.in");
        }
    }
}
