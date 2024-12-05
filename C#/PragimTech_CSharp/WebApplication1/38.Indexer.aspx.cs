using System;
using Indexers;
namespace WebApplication1
{
    public partial class Indexer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Using the string indexer to store session data
            Session["Session1"] = "Session 1 Data";

            // Using the string indexer to store session data
            Session["Session2"] = "Session 2 Data";

            // Using the integral indexer to retrieve data
            Response.Write("Session 1 Data = " + Session[0].ToString());
            Response.Write("<br/>");

            // Using the string indexer to retrieve data
            Response.Write("Session 2 Data = " + Session["Session2"].ToString());

            Company company = new Company();

            Response.Write("Name of the employees with id =2 " + company[2]);
            Response.Write("Number of Male " + company["Male"]);
            company["Female"] = "Male";
        }
    }
}