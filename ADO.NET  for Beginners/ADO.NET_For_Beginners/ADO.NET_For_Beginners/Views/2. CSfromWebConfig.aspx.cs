using System;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Web.UI.WebControls;
using System.Linq.Expressions;
using System.Configuration;

namespace ADO.NET_For_Beginners
{
    public partial class _2_CSfromWebConfig : System.Web.UI.Page
    {
        [Obsolete]
        protected void Page_Load(object sender, EventArgs e)
        {
           string ConnSQL= ConfigurationManager.ConnectionStrings["DBCSSql"].ConnectionString;  
            SqlConnection con = new SqlConnection(ConnSQL);
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
            string ConnOra = ConfigurationManager.ConnectionStrings["DBCSOracle"].ConnectionString; ;
            using (OracleConnection conOr = new OracleConnection(ConnOra))
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