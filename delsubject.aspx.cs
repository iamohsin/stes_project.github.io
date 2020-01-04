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
    public partial class delsubject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("main page.aspx");

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == "")
                Label3.Text = "Enter Subject ID";
            else
            {
                string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
                MySqlConnection connect = new MySqlConnection(connectstring);
                MySqlCommand cmd = new MySqlCommand("SELECT `subid`, `sub_code`, `sub_name`, semester.sem, program.pro , department.dep FROM `subject` INNER JOIN semester on subject.semid=semester.semid INNER JOIN program on subject.proid=program.proid INNER JOIN department on subject.depid=department.depid WHERE subject.subid='" + TextBox1.Text + "'", connect);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    data1();
                    Button5.Visible = true;
                }
                else
                    Label3.Text = "Subject Record Not found";
            }
        }
        void data1()
        {


            string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
            MySqlConnection connect = new MySqlConnection(connectstring);
            connect.Open();
            MySqlCommand sql = connect.CreateCommand();
            sql.CommandType = CommandType.Text;
            sql.CommandText = "SELECT `subid`, `sub_code`, `sub_name`, semester.sem, program.pro , department.dep FROM `subject` INNER JOIN semester on subject.semid=semester.semid INNER JOIN program on subject.proid=program.proid INNER JOIN department on subject.depid=department.depid WHERE subject.subid='" + TextBox1.Text + "'";
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

        protected void Button5_Click(object sender, EventArgs e)
        {
            string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
            MySqlConnection connect = new MySqlConnection(connectstring);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `subject` WHERE subid='" + TextBox1.Text + "'", connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            Response.Redirect("Manage subject.aspx");
        }
    }
}