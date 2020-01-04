using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace mas
{
    public partial class Manage_student : System.Web.UI.Page
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
                sql.CommandText = "SELECT student.Studentid as Student_ID,student.name as Name,student.fname as Sr_Name,email as Email,department.dep as Department,program.pro as Program,semester.sem as Semester,session.ses as Session FROM student INNER JOIN department ON student.depid = department.depid INNER JOIN program ON student.proid = program.proid INNER JOIN semester ON student.semid = semester.semid INNER JOIN session ON student.sesid = session.sesid";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataSourceID = String.Empty;
                connect.Close();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("addnewstd.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("delstd.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}