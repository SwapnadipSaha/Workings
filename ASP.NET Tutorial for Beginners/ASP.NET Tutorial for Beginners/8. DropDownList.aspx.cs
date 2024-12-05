using System;
using System.Data;
using System.Data.OracleClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace ASPDotNET_Tutorial_for_Beginners
{
    public partial class DropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Insert(0, "~Select~");
            DropDownList3.Items.Insert(0, "~Select~");



            ListItem l1 = new ListItem("Male", "M");
            ListItem l2 = new ListItem("FeMale", "F");
            ListItem l3 = new ListItem("Unknown", "U");
            ListItem l4 = new ListItem("Others", "O", false); //Setting enabled false

            if (!IsPostBack)
            {
               
                DropDownList1.Items.Add(l1);
                DropDownList1.Items.Add(l2);
                DropDownList1.Items.Add(l3);
                DropDownList1.Items.Add(l4);
                ddlCity.Items.Insert(0, "~Select City~");
                ddlState.Items.Insert(0, "~Select State~");

            }
            string connectionString = ConfigurationManager.AppSettings["DBConnectionString"];
            using (OracleConnection sCon = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand("SELECT GCI_CITY_CD CITY_CD,GCI_CITY_NAME CITY_NAME FROM GA_CITY_MASTER  Order by GCI_CITY_CD", sCon);
                sCon.Open();
                DropDownList2.DataSource = cmd.ExecuteReader();
                //DropDownList2.DataTextField = "CITY_NAME";
                //DropDownList2.DataValueField = "CITY_CD";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, "~Select~");
            }

            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/contents/Country.xml"));
            DropDownList4.DataSource = ds;
            DropDownList4.DataTextField = "CountryName";
            DropDownList4.DataValueField = "CountryId";
            DropDownList4.DataBind();
            DropDownList4.Items.Insert(0, "~Select~");



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("From Designer SelectedItem.Text-" + DropDownList3.SelectedItem.Text + "<br/>");
            Response.Write("From CodeBehind SelectedItem.Value-" + DropDownList1.SelectedItem.Value + "<br/>");
            Response.Write("From DataBase SelectedValue-" + DropDownList2.SelectedValue + "<br/>");
            Response.Write("From XML SelectedIndex-" + DropDownList4.SelectedIndex + "<br/>");



        }
    }
}