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
    public partial class tea_sub : System.Web.UI.Page
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
            using (MySqlConnection connect = new MySqlConnection(connectstring))
            {

                if (!Page.IsPostBack)
                {

                    connect.Open();
                    {
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM department", connect);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataSet myDataSet = new DataSet();
                        da.Fill(myDataSet);
                        DropDownList1.DataSource = myDataSet;
                        DropDownList1.DataTextField = "dep";
                        DropDownList1.DataValueField = "depid";

                        DropDownList1.DataBind();

                    }
                    connect.Close();
                }
            }
        }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
            MySqlConnection connect = new MySqlConnection(connectstring);
            connect.Open();
            MySqlCommand sql = connect.CreateCommand();
            sql.CommandType = CommandType.Text;
            sql.CommandText = "SELECT  teacher.name as Teacher_Name,subject.sub_code as Course_Code,subject.sub_name as Subject_Name,semester.sem as Semester,program.pro as Program,department.dep as Department FROM tea_sub INNER JOIN teacher on tea_sub.teacherid = teacher.teacherid INNER JOIN subject on tea_sub.subid = subject.subid INNER JOIN semester on subject.semid = semester.semid INNER JOIN program on subject.proid = program.proid INNER JOIN department on subject.depid = department.depid WHERE department.depid ='" + DropDownList1.SelectedValue + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataSourceID = String.Empty;
            connect.Close();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}