using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Tutorial_for_Beginners
{
    public partial class ListControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AddListItems(CheckBoxList2);
                AddListItems(DropDownList2);
                AddListItems(RadioButtonList2);
                AddListItems(ListBox2);
                AddListItems(BulletedList2);
            }
        }
        public void AddListItems(ListControl listControls)
        {
            ListItem L1 = new ListItem("Item 1", "1");
            ListItem L2 = new ListItem("Item 2", "2");
            ListItem L3 = new ListItem("Item 3", "3");

            listControls.Items.Add(L1);
            listControls.Items.Add(L2);
            listControls.Items.Add(L3);
        }

        public void RetrieveMultipleData(ListControl listControls)
        {
            foreach (ListItem li in listControls.Items)
            {
                if (li.Selected)
                {
                    Response.Write(listControls + "<br/>");
                    Response.Write("Value is - " + li.Value + "<br/>");
                    Response.Write("Text is - " + li.Text + "<br/>");
                    Response.Write("Index is - " + ListBox1.Items.IndexOf(li) + "<br/>");
                }
            }
        }

        public void RetrieveSingleData(ListControl listControls)
        {
            if (listControls.SelectedIndex!=-1)
            {
                Response.Write(listControls + "<br/>");
                Response.Write("Value is - " + listControls.SelectedItem.Value + "<br/>");
                Response.Write("Text is - " + listControls.SelectedItem.Text + "<br/>");
                Response.Write("Index is - " + listControls.SelectedIndex.ToString() + "<br/>");
            }

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            RetrieveMultipleData(CheckBoxList2);
            RetrieveMultipleData(ListBox2);
            RetrieveMultipleData(BulletedList2);
            RetrieveSingleData(ListBox2);
            RetrieveSingleData(DropDownList2);
            RetrieveSingleData(RadioButtonList2);
            RetrieveSingleData(BulletedList2);

        }
    }
}
