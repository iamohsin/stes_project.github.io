using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace mas
{
    public partial class Assignsub : System.Web.UI.Page
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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
            using (MySqlConnection connect = new MySqlConnection(connectstring))
            {



                connect.Open();
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM teacher WHERE teacher.depid='" + DropDownList1.SelectedValue + "'", connect);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet myDataSet = new DataSet();
                    da.Fill(myDataSet);
                    DropDownList2.DataSource = myDataSet;
                    DropDownList2.DataTextField = "name";
                    DropDownList2.DataValueField = "teacherid";

                    DropDownList2.DataBind();

                }
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM subject WHERE subject.depid='" + DropDownList1.SelectedValue + "'", connect);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet myDataSet = new DataSet();
                    da.Fill(myDataSet);
                    DropDownList3.DataSource = myDataSet;
                    DropDownList3.DataTextField = "sub_name";
                    DropDownList3.DataValueField = "subid";

                    DropDownList3.DataBind();

                }
                connect.Close();
                Label3.Visible = true;
                Label4.Visible = true;
                Button3.Visible = true;
                DropDownList2.Visible = true;
                DropDownList3.Visible = true;

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
            MySqlConnection connect = new MySqlConnection(connectstring);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `tea_sub`(`tbid`, `teacherid`, `subid`) VALUES ('" + null + "','" + DropDownList2.SelectedValue + "','" +DropDownList3.SelectedValue  + "')", connect);
            cmd.ExecuteNonQuery();


            connect.Close();
            Response.Redirect("manage subject.aspx");
        }
    }
}