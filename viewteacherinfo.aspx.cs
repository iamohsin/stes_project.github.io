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
    public partial class viewteacherinfo : System.Web.UI.Page
    {
        int sid;
        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("main page.aspx");

                }
                else
                {
                    string str;

                    MySqlCommand com;
                    MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=stes_project");

                    con.Open();
                    str = "SELECT* FROM teacher WHERE user = '" + Session["User"] + "' && pass='" + Session["pass"] + "'";
                    com = new MySqlCommand(str, con);
                    MySqlDataAdapter da = new MySqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    Label2.Text = ds.Tables[0].Rows[0]["teacherid"].ToString();

                    sid = Convert.ToInt32(Label2.Text);
                    Label2.Visible = false;

                }
                {

                    string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
                    MySqlConnection connect = new MySqlConnection(connectstring);
                    connect.Open();
                    MySqlCommand sql = connect.CreateCommand();
                    sql.CommandType = CommandType.Text;
                    sql.CommandText = "SELECT teacher.teacherid as Teacher_ID,teacher.name as Name,department.dep as Department,user as UserName,pass as Password FROM teacher INNER JOIN department ON teacher.depid = department.depid  WHERE teacher.teacherid='" + sid + "'";
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(sql);
                    da.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataSourceID = String.Empty;
                    connect.Close();
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}