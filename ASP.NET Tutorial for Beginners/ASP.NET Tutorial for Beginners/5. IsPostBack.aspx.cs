using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDotNET_Tutorial_for_Beginners
{
    public partial class IsPostBackEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//or if(!Page.IspostBack)
            { 
                Response.Write("Page Loaded First Time");
               LoadCity();
            }
            //LoadCity();    // This will duplicate the list items in drodown for every click. So should be in !IsPostBack
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        public void LoadCity()
        {
            ListItem li = new ListItem("London");
            DropDownList1.Items.Add(li);
        }

    }
}