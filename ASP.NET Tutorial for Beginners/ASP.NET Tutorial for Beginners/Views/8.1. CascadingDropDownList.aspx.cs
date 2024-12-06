using System;
using System.Data;
using System.Data.OracleClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace ASPDotNET_Tutorial_for_Beginners
{
    public partial class CascadingDropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCountry.DataSource = GetData("P_GET_COUNTRY", null);
                ddlCountry.DataValueField = "COUNTRY_CD";
                ddlCountry.DataTextField = "COUNTRY_DESC";
                ddlCountry.DataBind();
                ddlCountry.Items.Insert(0, "~Select Country~");
                ddlState.Items.Insert(0, "~Select State~");
                ddlCity.Items.Insert(0, "~Select City~");

            }
        }
        public DataSet GetData(String SPName, OracleParameter SPParameter)
        {
            string connectionString = ConfigurationManager.AppSettings["DBConnectionString"];
            OracleConnection sCon = new OracleConnection(connectionString);
            OracleDataAdapter da = new OracleDataAdapter(SPName, connectionString);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (SPParameter != null)
            {
                da.SelectCommand.Parameters.Add(SPParameter);
            }
            OracleParameter refCursor = new OracleParameter("RC1", OracleType.Cursor);
            refCursor.Direction = ParameterDirection.Output;
            da.SelectCommand.Parameters.Add(refCursor);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCountry.SelectedValue.ToString() != "~Select Country~")
            {
                ddlState.Enabled = true;
                ddlCity.Enabled = false;
                ddlCity.ClearSelection();
                ddlCity.Items.Insert(0, "~Select City~");
                OracleParameter parameter = new OracleParameter("P_COUNTRY_CD", ddlCountry.SelectedValue.ToString());
                ddlState.DataSource = GetData("P_GET_STATE", parameter);
                ddlState.DataTextField = "state_desc";
                ddlState.DataValueField = "State_cd";
                ddlState.DataBind();
                ddlState.Items.Insert(0, "~Select State~");
            }
            else
            {
                ddlState.Items.Insert(0, "~Select State~");
                ddlCity.Items.Insert(0, "~Select City~");
                ddlState.Enabled = false;
                ddlCity.Enabled = false;

            }




        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlState.SelectedValue.ToString() != "~Select State~")
            {
                ddlCity.Enabled = true;
                OracleParameter parameter = new OracleParameter("P_STATE_CD", ddlState.SelectedValue.ToString());
                ddlCity.DataSource = GetData("P_GET_CITY", parameter);
                ddlCity.DataTextField = "CITY_DESC";
                ddlCity.DataValueField = "CITY_CD";
                ddlCity.DataBind();

            }
            else
            {
                ddlCity.Enabled = false;
                ddlCity.ClearSelection();
                ddlCity.Items.Insert(0, "~Select City~");
            }
        }
    }
}