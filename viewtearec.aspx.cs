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
    public partial class viewtearec : System.Web.UI.Page
    {
        int sid, sdep;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("main page.aspx");

            }
            else
            {
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

                    Label3.Text = ds.Tables[0].Rows[0]["hodid"].ToString();
                    sid = Convert.ToInt32(Label3.Text);
                    Label5.Text = ds.Tables[0].Rows[0]["depid"].ToString();
                    sdep = Convert.ToInt32(Label5.Text);

                }


                string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
                using (MySqlConnection connect = new MySqlConnection(connectstring))
                {

                    if (!Page.IsPostBack)
                    {

                        connect.Open();
                        {
                            MySqlCommand cmd = new MySqlCommand("SELECT tea_sub.teacherid,teacher.name,tea_sub.subid, subject.sub_name FROM tea_sub INNER JOIN teacher on tea_sub.teacherid=teacher.teacherid INNER JOIN subject on tea_sub.subid=subject.subid WHERE subject.depid='" + sdep + "'", connect);

                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataSet myDataSet = new DataSet();
                            da.Fill(myDataSet);
                            DropDownList1.DataSource = myDataSet;
                            DropDownList1.DataTextField = "name";
                            DropDownList1.DataValueField = "teacherid";

                            DropDownList1.DataBind();

                        }


                        connect.Close();
                    }
                    if (DropDownList1.SelectedValue == "")
                        Label6.Text = "No Teachers found in your Department";
                    else
                    {
                        Label2.Visible = true;
                        DropDownList1.Visible = true;
                        Button1.Visible = true;
                            
                    }
                }
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Visible = false;
            DropDownList1.Visible = false;
            Button1.Visible = false;
            Button2.Visible = true;
            {

                string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
                MySqlConnection connect = new MySqlConnection(connectstring);
                connect.Open();
                MySqlCommand sql = connect.CreateCommand();
                sql.CommandType = CommandType.Text;
                sql.CommandText = "SELECT question.ques as Question,options.opt as Selected ,COUNT(evaluation.optid) as Total_student FROM `evaluation`  JOIN teacher ON teacher.teacherid = evaluation.tid JOIN options ON options.optid = evaluation.optid JOIN question ON question.qid = evaluation.quesid WHERE evaluation.tid = '" + DropDownList1.SelectedValue + "' GROUP by evaluation.tid,evaluation.optid,evaluation.quesid";
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
                sql.CommandText = "SELECT options.opt as Report , COUNT(evaluation.optid) as Total FROM `evaluation` JOIN teacher ON teacher.teacherid=evaluation.tid JOIN options ON options.optid= evaluation.optid WHERE evaluation.tid= '" + DropDownList1.SelectedValue + "' GROUP by evaluation.tid, evaluation.optid";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                da.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataSourceID = String.Empty;
               
                connect.Close();

                


            }
           
        }
    }
}