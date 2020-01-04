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
    public partial class viewhodinfo : System.Web.UI.Page
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
                    str = "SELECT* FROM hod WHERE user = '" + Session["User"] + "' && pass='" + Session["pass"] + "'";
                    com = new MySqlCommand(str, con);
                    MySqlDataAdapter da = new MySqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    Label2.Text = ds.Tables[0].Rows[0]["hodid"].ToString();

                    sid = Convert.ToInt32(Label2.Text);
                    Label2.Visible = false;

                }
                {

                    string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
                    MySqlConnection connect = new MySqlConnection(connectstring);
                    connect.Open();
                    MySqlCommand sql = connect.CreateCommand();
                    sql.CommandType = CommandType.Text;
                    sql.CommandText = "SELECT hod.hodid as Hod_ID,hod.name as Name,department.dep as Department,user as UserName,pass as Password FROM hod INNER JOIN department ON hod.depid = department.depid  WHERE hod.hodid='" + sid + "'";
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