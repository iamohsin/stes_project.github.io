using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace mas
{
    public partial class student_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label7.Text = "Enter Info";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" && TextBox2.Text == "")
                Label7.Text = "Enter Info";
            else
            {
                string sql = string.Empty;
                string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
                MySqlConnection connect = new MySqlConnection(connectstring);
                connect.Open();
                sql = "SELECT * from student where user='" + TextBox1.Text + "' and pass = '" + TextBox2.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    Session["user"] = TextBox1.Text;
                    Session["pass"] = TextBox2.Text;

                    Response.Redirect("student home.aspx");
                }
                else
                {
                    Label7.Text = "Sorry record Not found";
                }

            }
        }
    }
}