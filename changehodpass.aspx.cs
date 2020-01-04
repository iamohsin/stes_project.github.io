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
    public partial class changehodpass : System.Web.UI.Page
    {
        int sid;
        protected void Page_Load(object sender, EventArgs e)
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
                Label5.Text = ds.Tables[0].Rows[0]["hodid"].ToString();

                sid = Convert.ToInt32(Label5.Text);


            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Label4.Text = "Enter Current Password";
                Label4.Visible = true;
            }

            else
            {
                string sql = string.Empty;
                string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
                MySqlConnection connect = new MySqlConnection(connectstring);
                connect.Open();
                sql = "SELECT * from hod where user='" + Session["User"] + "' and pass = '" + TextBox1.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    Label3.Visible = true;
                    TextBox2.Visible = true;
                    Button3.Visible = true;
                    Label4.Visible = false;

                    Label2.Visible = false;
                    TextBox1.Visible = false;
                    Button2.Visible = false;



                }
                else
                {
                    Label4.Text = "Password Incorrect";
                    Label4.Visible = true;
                }
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
            MySqlConnection connect = new MySqlConnection(connectstring);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `hod` SET `pass`='" + Convert.ToInt32(TextBox2.Text) + "' WHERE hodid='" + sid + "'", connect);

            cmd.ExecuteNonQuery();
            connect.Close();
            Response.Redirect("main page.aspx");
        }
    }
}