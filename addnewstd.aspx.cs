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
    public partial class addnewstd : System.Web.UI.Page
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
                        {
                            MySqlCommand cmd = new MySqlCommand("SELECT * FROM program", connect);

                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataSet myDataSet = new DataSet();
                            da.Fill(myDataSet);
                            DropDownList2.DataSource = myDataSet;
                            DropDownList2.DataTextField = "pro";
                            DropDownList2.DataValueField = "proid";
                            DropDownList2.DataBind();
                        }
                        {
                            MySqlCommand cmd = new MySqlCommand("SELECT * FROM semester", connect);

                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataSet myDataSet = new DataSet();
                            da.Fill(myDataSet);
                            DropDownList3.DataSource = myDataSet;
                            DropDownList3.DataTextField = "sem";
                            DropDownList3.DataValueField = "semid";

                            DropDownList3.DataBind();
                        }
                        {
                            MySqlCommand cmd = new MySqlCommand("SELECT * FROM session", connect);

                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataSet myDataSet = new DataSet();
                            da.Fill(myDataSet);
                            DropDownList4.DataSource = myDataSet;
                            DropDownList4.DataTextField = "ses";
                            DropDownList4.DataValueField = "sesid";
                            DropDownList4.DataBind();


                        }


                        connect.Close();
                    }
                }
            }
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {
            

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" && TextBox2.Text == "" && TextBox3.Text == "" && TextBox4.Text == "" && TextBox5.Text == "")
                Label9.Text = "Enter All Info";
            else
            {
                
                    add();
            }
        }
            void add(){
                string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
                MySqlConnection connect = new MySqlConnection(connectstring);
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO student (`studentid`, `name`, `user`, `pass`, `depid`, `proid`, `sesid`,semid,fname,email) VALUES ('" + null + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + DropDownList1.SelectedValue + "','" + DropDownList2.SelectedValue + "','" + DropDownList4.SelectedValue + "','" + DropDownList3.SelectedValue + "','" + TextBox4.Text + "','" + TextBox5.Text + "')", connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                Response.Redirect("manage student.aspx");
            }
        }
    }
