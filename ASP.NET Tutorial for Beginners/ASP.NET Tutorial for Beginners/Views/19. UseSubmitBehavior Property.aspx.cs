using System;

namespace ASP.NET_Tutorial_for_Beginners
{
    public partial class _18_UseSubmitBehavior_Property : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMsg.Text ="You Entered: " +txtName.Text;
        }
    }
}