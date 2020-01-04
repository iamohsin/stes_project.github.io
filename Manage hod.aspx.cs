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
    public partial class Manage_hod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("main page.aspx");

            }
            else
            {
                string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
                MySqlConnection connect = new MySqlConnection(connectstring);
                connect.Open();
                MySqlCommand sql = connect.CreateCommand();
                sql.CommandType = CommandType.Text;
                sql.CommandText = "SELECT hod.hodid as HOD_ID,hod.name as Name,department.dep as Department FROM hod INNER JOIN department on hod.depid = department.depid";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataSourceID = String.Empty;
                connect.Close();
            }
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("addhod.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("delhod.aspx");
        }
    }
}