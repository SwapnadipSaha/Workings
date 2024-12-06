using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Tutorial_for_Beginners
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void Upload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (fileExtension == ".docx")
                {
                    int fileSize = FileUpload1.PostedFile.ContentLength;
                    if (fileSize <= 20000)
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/contents/" + FileUpload1.FileName));
                        lblStatus.Text = "Success";
                        lblStatus.ForeColor = System.Drawing.Color.Red;
                    }
                    else {
                        lblStatus.Text = "Size exceeds";
                        lblStatus.ForeColor = System.Drawing.Color.DarkRed;
                    }

                }
                else {
                    lblStatus.Text = "Upload word only";
                    lblStatus.ForeColor = System.Drawing.Color.DeepSkyBlue;
                }

            }
            else
            {
                lblStatus.Text = "Select a file";
                lblStatus.ForeColor = System.Drawing.Color.GreenYellow;
            }
        }
    }
}
