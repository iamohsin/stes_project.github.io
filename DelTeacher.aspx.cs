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
    public partial class DelTeacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("main page.aspx");

            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
            MySqlConnection connect = new MySqlConnection(connectstring);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `teacher` WHERE teacherid='" + TextBox1.Text + "'", connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            Response.Redirect("Manage teacher.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
                Label3.Text = "Enter Student ID";
            else
            {
                string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
                MySqlConnection connect = new MySqlConnection(connectstring);
                MySqlCommand cmd = new MySqlCommand("SELECT `teacherid`, `name`, `user`, `pass`, department.dep FROM Teacher INNER JOIN department ON Teacher.depid = department.depid WHERE teacherid ='" + TextBox1.Text + "'",connect);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    data1();
                    Button3.Visible = true;
                }
                else
                    Label3.Text = "Teacher Record Not found";
            }
        }
            void data1(){
                

                string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
                MySqlConnection connect = new MySqlConnection(connectstring);
                connect.Open();
                MySqlCommand sql = connect.CreateCommand();
                sql.CommandType = CommandType.Text;
                sql.CommandText = "SELECT `teacherid`, `name`, `user`, `pass`, department.dep FROM Teacher INNER JOIN department ON Teacher.depid = department.depid WHERE teacherid ='" + TextBox1.Text + "'";
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
