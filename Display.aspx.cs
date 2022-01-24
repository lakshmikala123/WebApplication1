using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;



namespace WebApplication1
{
    public partial class Display : System.Web.UI.Page
    {
        //String Connectionstring=ConfigurationManager.ConnectionStrings["oracleDB"].ConnectionString.ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            string oradb = "Data Source=L-158031343;User ID=lakshmi;Password=tiger;";
            //OracleConnection conn = new OracleConnection(oradb);
            OracleConnection _connection = new OracleConnection(oradb);
          //  _connection.ConnectionString = Connectionstring;
            _connection.Open();
            //string sql = "select * from EMP";
            OracleCommand command = new OracleCommand();
            command.Connection = _connection;
            command.CommandText = "select * from EMP";
            command.CommandType = CommandType.Text;
            //DataTable dt = new DataTable();
           
         
            Empgv.DataSource = command.ExecuteReader();
            Empgv.DataBind();
            _connection.Close();

        }
    }
}