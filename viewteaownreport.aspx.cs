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
    public partial class viewteaownreport : System.Web.UI.Page
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
                sql.CommandText = "SELECT question.ques as Question,options.opt as Selected ,COUNT(evaluation.optid) as Total_student FROM `evaluation`  JOIN teacher ON teacher.teacherid = evaluation.tid JOIN options ON options.optid = evaluation.optid JOIN question ON question.qid = evaluation.quesid WHERE evaluation.tid = '" + sid+"' GROUP by evaluation.tid,evaluation.optid,evaluation.quesid";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataSourceID = String.Empty;
                connect.Close();
            }
            {

                string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
                MySqlConnection connect = new MySqlConnection(connectstring);
                connect.Open();
                MySqlCommand sql = connect.CreateCommand();
                sql.CommandType = CommandType.Text;
                sql.CommandText = "SELECT options.opt as Report , COUNT(evaluation.optid) as Total FROM `evaluation` JOIN teacher ON teacher.teacherid=evaluation.tid JOIN options ON options.optid= evaluation.optid WHERE evaluation.tid= '" + sid + "' GROUP by evaluation.tid, evaluation.optid";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                da.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataSourceID = String.Empty;
                connect.Close();

                if (GridView2.Rows.Count == 0)
                {
                    Label3.Text = "Evaluation Is Pending (Students has not Evaluate)";
                    Label3.Visible = true;

                }
            }
        }
        
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}