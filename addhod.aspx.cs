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
    public partial class addhod : System.Web.UI.Page
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

        

            

        protected void Button2_Click1(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" && TextBox2.Text == "" && TextBox3.Text == "")
                Label11.Text = "Enter All Info";
            else
            {

                add();
            }
        }
        void add()
        {
            string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
            MySqlConnection connect = new MySqlConnection(connectstring);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `hod`(`hodid`, `name`, `user`, `pass`,`depid`) VALUES  ('" + null + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + DropDownList1.SelectedValue + "')", connect);
            cmd.ExecuteNonQuery();


            connect.Close();
            Response.Redirect("manage hod.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }