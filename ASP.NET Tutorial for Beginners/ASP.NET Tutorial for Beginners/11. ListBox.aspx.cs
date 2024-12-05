using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Tutorial_for_Beginners
{
    public partial class ListBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                //case "SelectAll":
                //    foreach (ListItem li in CheckBoxList1.Items)
                //    {
                //        li.Selected = true;
                //     }
                //        break;

                //case "DeSelectAll":
                //    foreach (ListItem li in CheckBoxList1.Items)
                //    {
                //        li.Selected = false;
                //    }
                //    break;

                case "Print":
                    if (ListBox1.SelectedItem is null)
                        {
                            Response.Write("Nothing Selected.");
                        }
                        else
                        {
                            foreach (ListItem li in ListBox1.Items)
                            {
                                if (li.Selected)
                                {
                                    Response.Write("Value is - " + li.Value + "<br/>");
                                    Response.Write("Text is - " + li.Text + "<br/>");
                                    Response.Write("Index is - " + ListBox1.Items.IndexOf(li) + "<br/>");
                                }


                            }
                        }
                        break;
                default:
                    break;
                    }

            }

            protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (ListBox1.SelectedItem is null)
                {
                    Response.Write("Nothing Selected.");
                }
                else
                {
                    foreach (ListItem li in ListBox1.Items)
                    {
                        if (li.Selected)
                        {
                            Response.Write("Value is - " + li.Value + "<br/>");
                            Response.Write("Text is - " + li.Text + "<br/>");
                            Response.Write("Index is - " + ListBox1.Items.IndexOf(li) + "<br/>");
                        }


                    }
                }
            }
        }
    }