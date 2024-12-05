using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Tutorial_for_Beginners
{
    public partial class _23_CustomValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            bool isNumber = int.TryParse(args.Value, out int number);
            string input = args.Value?.Trim();

            if (!isNumber || number <= 0 || number % 2 != 0)
            {

                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblStatus.Text = "Saved";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblStatus.Text = "Validation Error";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
