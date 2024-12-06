using System;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Web.UI.WebControls;
using System.Linq.Expressions;


namespace ADO.NET_For_Beginners
{
    public partial class _1_Introduction : System.Web.UI.Page
    {
        [Obsolete]
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=.;database=MySQLDB;integrated security=SSPI");
            SqlCommand cmd = new SqlCommand("Select TMP_MR_NUM Patient_Number,TMP_PAT_NUM MR_NUMBER,TMP_EFF_DATE DateSQL from tmp_costing_data order by tmp_mr_num asc", con);
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                GridView1.DataSource = rdr;
                GridView1.DataBind();
            }
            catch
            {

            }
            finally
            {
                con.Close();

            }
            string connectionString = "Data Source=TMCTEST;User ID=tmclive;pwd=tmclive;integrated security = no";
            using (OracleConnection conOr = new OracleConnection(connectionString))
            {
                OracleCommand cmdOr = new OracleCommand("Select TMP_MR_NUM Patient_Number,TMP_PAT_NUM MR_NUMBER,TMP_EFF_DATE DateOracle from tmp_costing_data  order by tmp_mr_num desc", conOr);

                conOr.Open();
                OracleDataReader rdrOr = cmdOr.ExecuteReader();
                GridView2.DataSource = rdrOr;
                GridView2.DataBind();
            }

        }
    }
}