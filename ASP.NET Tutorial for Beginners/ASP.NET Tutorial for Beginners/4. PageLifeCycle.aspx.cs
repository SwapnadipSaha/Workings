using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDotNET_Tutorial_for_Beginners
{
    public partial class PageLifeCycle : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button Clicked" + "<br/>");
        }
        //9
        protected void Page_Unload(object sender, EventArgs e)
        {
            //Response.Write("Page_Unload" + "<br/>");
        }
        //3
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page_PreLoad" + "<br/>");
        }
        //4
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Page_InitComplete" + "<br/>");
        }
        //8
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("Page_PreRenderComplete" + "<br/>");
            //Response.Write("Page_Unload" + "<br/>");
        }
        //5
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page_Load" + "<br/>");
           
        }
        //2
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init" + "<br/>");
        }
        //6
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Page_LoadComplete" + "<br/>");
        }
        //7
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender" + "<br/>");
        }
        //1
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_PreInit" + "<br/>");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Text Changed"+"<br/>");
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            Response.Write("Page_Error" + "<br/>" +e.ToString());

        }
    }
}