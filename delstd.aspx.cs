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
    public partial class delstd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null)
            {
                Response.Redirect("main page.aspx");

            }
            


      }
            

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
                Label3.Text = "Enter Student ID";
            else
            {
                string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
                MySqlConnection connect = new MySqlConnection(connectstring);
                MySqlCommand cmd = new MySqlCommand("SELECT student.Studentid, student.name, department.dep, program.pro, semester.sem, session.ses FROM student INNER JOIN department ON student.depid = department.depid INNER JOIN program ON student.proid = program.proid INNER JOIN semester ON student.semid = semester.semid INNER JOIN session ON student.sesid = session.sesid WHERE studentid = '" + TextBox1.Text + "'",connect);
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
                    Label3.Text = "Student Record Not found";
            }

        } 
    
        void data1()
        {
            string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
            MySqlConnection connect = new MySqlConnection(connectstring);
            connect.Open();
            MySqlCommand sql = connect.CreateCommand();
            sql.CommandType = CommandType.Text; 
            sql.CommandText = "SELECT student.Studentid,student.name,department.dep,program.pro,semester.sem,session.ses FROM student INNER JOIN department ON student.depid = department.depid INNER JOIN program ON student.proid = program.proid INNER JOIN semester ON student.semid = semester.semid INNER JOIN session ON student.sesid = session.sesid WHERE studentid='"+TextBox1.Text+"'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataSourceID = String.Empty;
            connect.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
            MySqlConnection connect = new MySqlConnection(connectstring);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `student` WHERE studentid='" + TextBox1.Text + "'",connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            Response.Redirect("manage student.aspx");
        }
    }
}