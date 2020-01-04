using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace mas
{
    public partial class questions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
            MySqlConnection connect = new MySqlConnection(connectstring);
            connect.Open();
            MySqlCommand sql = connect.CreateCommand();
            sql.CommandType = CommandType.Text;
            sql.CommandText = "SELECT  `qid`,`ques` FROM `question` ";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataSourceID = String.Empty;
            connect.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}