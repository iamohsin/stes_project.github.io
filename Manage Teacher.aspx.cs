using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace mas
{
    public partial class Manage_Teacher : System.Web.UI.Page
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
            sql.CommandText = "SELECT teacher.teacherid as Teacher_ID,teacher.name as Name,department.dep as Department FROM teacher INNER JOIN department on teacher.depid = department.depid";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataSourceID = String.Empty;
            connect.Close();
        } }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("addteacher.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Delteacher.aspx");
        }
    }
}