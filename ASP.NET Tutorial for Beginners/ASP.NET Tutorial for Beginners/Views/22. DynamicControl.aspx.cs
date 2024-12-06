using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace ASP.NET_Tutorial_for_Beginners
{
    public partial class _22_DynamicControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerateControl_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(TextControlsCount.Text);
            foreach (ListItem lst in chkBoxListcontreltype.Items)
            {
                if (lst.Selected)
                    if (lst.Value == "Label")
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            Label lbl = new Label();
                            lbl.Text = "Label - " + i.ToString();
                            //this.Page.Controls.Add(lbl);
                            this.form1.Controls.Add(lbl);
                            // pnlLabels.Controls.Add(lbl);
                        }

                    }

                    else if (lst.Value == "TextBox")
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            TextBox txt = new TextBox();
                            txt.Text = "TextBox - " + i.ToString();
                            //this.Page.Controls.Add(txt);
                            //this.form1.Controls.Add(txt);
                            tdTxtBoxes.Controls.Add(txt);
                            //pnlTxtBoxes.Controls.Add(txt);
                        }

                    }


                    else
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            Button btn = new Button();
                            btn.Text = "Button - " + i.ToString();
                            //this.Page.Controls.Add(btn);
                            //this.form1.Controls.Add(btn);
                            // pnlButton.Controls.Add(btn);
                            PlaceHolder1.Controls.Add(btn);
                        }

                    }
            }
        }
    }
}