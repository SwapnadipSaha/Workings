using System;
using System.Text;


namespace ASPDotNET_Tutorial_for_Beginners
{
    public partial class CheckBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            StringBuilder userChoice = new StringBuilder();

            if (CheckBox1.Checked)
            {
                userChoice.Append(CheckBox1.Text);               
            }
            if (CheckBox2.Checked)
            {
                userChoice.Append( CheckBox2.Text);
            }
            if (CheckBox3.Checked)            
            {
                userChoice.Append( CheckBox3.Text);
            }
            Response.Write(userChoice);
        }
    }
}