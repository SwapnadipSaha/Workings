using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Tutorial_for_Beginners
{
    public partial class CheckRadioBulletBoxList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "SelectAll":
                    foreach (ListItem li in CheckBoxList1.Items)
                    {
                        li.Selected = true;
                     }
                        break;

                case "DeSelectAll":
                    foreach (ListItem li in CheckBoxList1.Items)
                    {
                        li.Selected = false;
                    }
                    break;

                case "Print":
                    if (CheckBoxList1.SelectedItem is null)
                        {
                            Response.Write("Nothing Selected.");
                        }
                        else
                        {
                            foreach (ListItem li in CheckBoxList1.Items)
                            {
                                if (li.Selected)
                                {
                                    Response.Write("Value is - " + li.Value + "<br/>");
                                    Response.Write("Text is - " + li.Text + "<br/>");
                                    Response.Write("Index is - " + CheckBoxList1.Items.IndexOf(li) + "<br/>");
                                }


                            }
                        }
                        break;

                case "Radio":
                    if (CheckBoxList2.SelectedItem is null)
                    {
                        Response.Write("Nothing Selected.");
                    }
                    else
                    {
                        foreach (ListItem li in CheckBoxList2.Items)
                        {
                            if (li.Selected)
                            {
                                Response.Write("Value is - " + li.Value + "<br/>");
                                Response.Write("Text is - " + li.Text + "<br/>");
                                Response.Write("Index is - " + CheckBoxList2.Items.IndexOf(li) + "<br/>");
                            }


                        }
                    }
                    break;
                default:
                    break;
                    }

            }

            protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (CheckBoxList1.SelectedItem is null)
                {
                    Response.Write("Nothing Selected.");
                }
                else
                {
                    foreach (ListItem li in CheckBoxList1.Items)
                    {
                        if (li.Selected)
                        {
                            Response.Write("Value is - " + li.Value + "<br/>");
                            Response.Write("Text is - " + li.Text + "<br/>");
                            Response.Write("Index is - " + CheckBoxList1.Items.IndexOf(li) + "<br/>");
                        }


                    }
                }
            }

        protected void CheckBoxList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckBoxList2.SelectedItem is null)
            {
                Response.Write("Nothing Selected.");
            }
            else
            {
                foreach (ListItem li in CheckBoxList1.Items)
                {
                    if (li.Selected)
                    {
                        Response.Write("Value is - " + li.Value + "<br/>");
                        Response.Write("Text is - " + li.Text + "<br/>");
                        Response.Write("Index is - " + CheckBoxList2.Items.IndexOf(li) + "<br/>");
                    }


                }
            }
        }

        protected void RadioButtonList1_Click(object sender, BulletedListEventArgs e)
        {
            ListItem li = RadioButtonList1.Items[e.Index];
            Response.Write("Value is - " + li.Value + "<br/>");
            Response.Write("Text is - " + li.Text + "<br/>");
            Response.Write("Index is - " + e.Index.ToString() + "<br/>");
        }
    }
    }