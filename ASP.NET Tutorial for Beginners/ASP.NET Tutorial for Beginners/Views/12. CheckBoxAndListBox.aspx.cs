using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Tutorial_for_Beginners
{
    public partial class _12_CheckBoxAndListBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();/// Not clearing, will add repeated items in the ListBox
            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                   /// ListBox1.Items.Add(li);      // Not including .Text Property, will make the ListBox items selected.
                    ListBox1.Items.Add(li.Text);   
                }
            }
            if (ListBox1.Items.Count == 0)
            {
                Label1.Text = "0 Items Seleteced";
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Font.Bold = true;
            }
            else
            {
                Label1.Text = ListBox1.Items.Count + "  Items Seleteced";
                Label1.ForeColor = System.Drawing.Color.Black;
                Label1.Font.Bold = true;
            }
        }


    }
}