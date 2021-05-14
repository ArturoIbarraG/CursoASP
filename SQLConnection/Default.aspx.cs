using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQLConnection
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM comestibles";
                    cmd.Connection = conn;
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    gdvComestibles.DataSource = reader;
                    gdvComestibles.DataBind();
                    reader.Close();
                    reader = cmd.ExecuteReader();
                    ddlComestibles.DataSource = reader;
                    ddlComestibles.DataValueField = "id";
                    ddlComestibles.DataTextField = "nombre";
                    ddlComestibles.DataBind();
                }
            }
        }
    }
}