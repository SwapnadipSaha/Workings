using System;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Web.UI.WebControls;
using System.Linq.Expressions;
using System.Configuration;

namespace ADO.NET_For_Beginners.Views
{
    public partial class _3_SqlOracleCommand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          string connectionString=  ConfigurationManager.ConnectionStrings["DBCSOracle"].ConnectionString;
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                OracleCommand command = new OracleCommand("Select TMP_MR_NUM Patient_Number,TMP_PAT_NUM MR_NUMBER,TMP_EFF_DATE DateOracle from tmp_costing_data order by tmp_mr_num asc", con);
                con.Open();
                OracleDataReader rdr = command.ExecuteReader();
                GridView1.DataSource = rdr; 
                GridView1.DataBind();
            }


            //or


            string connectionStringSql = ConfigurationManager.ConnectionStrings["DBCSSql"].ConnectionString;
            using (SqlConnection conSql = new SqlConnection(connectionStringSql))
            {
                SqlCommand commandSql = new SqlCommand();
                commandSql.CommandText = "Select TMP_MR_NUM Patient_Number,TMP_PAT_NUM MR_NUMBER,TMP_EFF_DATE DateSQL from tmp_costing_data order by tmp_mr_num desc";
                commandSql.Connection = conSql;
                conSql.Open();
                GridView2.DataSource = commandSql.ExecuteReader();
                GridView2.DataBind();
            }




            string connectionString2 = ConfigurationManager.ConnectionStrings["DBCSOracle"].ConnectionString;
            using (OracleConnection con = new OracleConnection(connectionString2))
            {
                OracleCommand command = new OracleCommand("Select count(1) from tmp_costing_data t order by tmp_mr_num asc", con);
                con.Open();
                lblOracle.Text  ="Oracle Count:" + command.ExecuteScalar().ToString();
                
            }


            //or


            string connectionStringSql2 = ConfigurationManager.ConnectionStrings["DBCSSql"].ConnectionString;
            using (SqlConnection conSql = new SqlConnection(connectionStringSql2))
            {
                SqlCommand commandSql = new SqlCommand();
                commandSql.CommandText = "Select count(tmp_pat_num) from tmp_costing_data t ";
                commandSql.Connection = conSql;
                conSql.Open();
                int rowCount = (int)commandSql.ExecuteScalar();
                lblSql.Text = "Sql Count:" + rowCount;
               
            }
        }
    }
}