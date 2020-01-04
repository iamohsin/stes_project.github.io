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
    public partial class Student_home : System.Web.UI.Page
    {
        int sid,sdep,spro,ssem;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("main page.aspx");

            }

            showdata();
            Panel1.Visible = false;

            string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
            using (MySqlConnection connect = new MySqlConnection(connectstring))
            {

                if (!Page.IsPostBack)
                {




                    connect.Open();
                    {
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM options", connect);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataSet myDataSet = new DataSet();
                        da.Fill(myDataSet);
                        RadioButtonList1.DataSource = myDataSet;
                        RadioButtonList1.DataTextField = "opt";
                        RadioButtonList1.DataValueField = "optid";
                        RadioButtonList1.DataBind();
                        RadioButtonList1.SelectedIndex=2;


                        RadioButtonList2.DataSource = myDataSet;
                        RadioButtonList2.DataTextField = "opt";
                        RadioButtonList2.DataValueField = "optid";
                        RadioButtonList2.DataBind();
                        RadioButtonList2.SelectedIndex = 2;

                        RadioButtonList3.DataSource = myDataSet;
                        RadioButtonList3.DataTextField = "opt";
                        RadioButtonList3.DataValueField = "optid";
                        RadioButtonList3.DataBind();
                        RadioButtonList3.SelectedIndex = 2;

                        RadioButtonList4.DataSource = myDataSet;
                        RadioButtonList4.DataTextField = "opt";
                        RadioButtonList4.DataValueField = "optid";
                        RadioButtonList4.DataBind();
                        RadioButtonList4.SelectedIndex = 2;

                        RadioButtonList5.DataSource = myDataSet;
                        RadioButtonList5.DataTextField = "opt";
                        RadioButtonList5.DataValueField = "optid";
                        RadioButtonList5.DataBind();
                        RadioButtonList5.SelectedIndex = 2;

                        RadioButtonList6.DataSource = myDataSet;
                        RadioButtonList6.DataTextField = "opt";
                        RadioButtonList6.DataValueField = "optid";
                        RadioButtonList6.DataBind();
                        RadioButtonList6.SelectedIndex = 2;

                        RadioButtonList7.DataSource = myDataSet;
                        RadioButtonList7.DataTextField = "opt";
                        RadioButtonList7.DataValueField = "optid";
                        RadioButtonList7.DataBind();
                        RadioButtonList7.SelectedIndex = 2;

                        RadioButtonList8.DataSource = myDataSet;
                        RadioButtonList8.DataTextField = "opt";
                        RadioButtonList8.DataValueField = "optid";
                        RadioButtonList8.DataBind();
                        RadioButtonList8.SelectedIndex = 2;

                        RadioButtonList9.DataSource = myDataSet;
                        RadioButtonList9.DataTextField = "opt";
                        RadioButtonList9.DataValueField = "optid";
                        RadioButtonList9.DataBind();
                        RadioButtonList9.SelectedIndex = 2;

                        RadioButtonList10.DataSource = myDataSet;
                        RadioButtonList10.DataTextField = "opt";
                        RadioButtonList10.DataValueField = "optid";
                        RadioButtonList10.DataBind();
                        RadioButtonList10.SelectedIndex = 2;

                        RadioButtonList11.DataSource = myDataSet;
                        RadioButtonList11.DataTextField = "opt";
                        RadioButtonList11.DataValueField = "optid";
                        RadioButtonList11.DataBind();
                        RadioButtonList11.SelectedIndex = 2;

                        RadioButtonList12.DataSource = myDataSet;
                        RadioButtonList12.DataTextField = "opt";
                        RadioButtonList12.DataValueField = "optid";
                        RadioButtonList12.DataBind();
                        RadioButtonList12.SelectedIndex = 2;

                        RadioButtonList13.DataSource = myDataSet;
                        RadioButtonList13.DataTextField = "opt";
                        RadioButtonList13.DataValueField = "optid";
                        RadioButtonList13.DataBind();
                        RadioButtonList13.SelectedIndex = 2;
                    }


                    connect.Close();
                }
            }
        }




            
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue=="")
                Label6.Text = "No Teachers found in your Semester";
            else {
                string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
                using (MySqlConnection connect = new MySqlConnection(connectstring))
                {



                    connect.Open();

                    {
                        MySqlCommand cmd = new MySqlCommand("SELECT  tea_sub.subid, subject.sub_name FROM tea_sub  INNER JOIN subject on tea_sub.subid = subject.subid WHERE tea_sub.teacherid = '" + DropDownList1.SelectedValue + "' && subject.semid='"+ ssem +"'", connect);
                        
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataSet myDataSet = new DataSet();
                        da.Fill(myDataSet);
                        DropDownList2.DataSource = myDataSet;
                        DropDownList2.DataTextField = "sub_name";
                        DropDownList2.DataValueField = "subid";

                        DropDownList2.DataBind();

                    }
                    connect.Close();


                    DropDownList2.Visible = true;
                    Button4.Visible = true;


                } }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            
                string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
            MySqlConnection connect = new MySqlConnection(connectstring);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `evaluation` WHERE evaluation.stdid='"+sid+"'&&evaluation.tid='"+DropDownList1.SelectedValue+ "'&&evaluation.sub_id='" + DropDownList2.SelectedValue + "'", connect);
            cmd.ExecuteNonQuery();
            connect.Close();


            string connectstring1 = ("datasource=localhost;username=root;password=;database=stes_project");
            MySqlConnection connect1 = new MySqlConnection(connectstring1);
            connect1.Open();
            MySqlCommand cmd1 = new MySqlCommand("INSERT INTO `evaluation` (`eval_id`, `stdid`, `tid`, `sub_id`, `quesid`, `optid`) VALUES('"+null+"','"+sid+"' ,'"+DropDownList1.SelectedValue+"','"+DropDownList2.SelectedValue+"','"+1+"','"+RadioButtonList1.SelectedValue+"'),('"+null+"', '"+sid+"', '"+DropDownList1.SelectedValue+"', '"+DropDownList2.SelectedValue+"', '"+2+"', '"+RadioButtonList2.SelectedValue+ "'),('" + null + "', '" + sid + "', '" + DropDownList1.SelectedValue + "', '" + DropDownList2.SelectedValue + "', '" + 3 + "', '" + RadioButtonList3.SelectedValue + "'),('" + null + "', '" + sid + "', '" + DropDownList1.SelectedValue + "', '" + DropDownList2.SelectedValue + "', '" + 4 + "', '" + RadioButtonList4.SelectedValue + "'),('" + null + "', '" + sid + "', '" + DropDownList1.SelectedValue + "', '" + DropDownList2.SelectedValue + "', '" + 5 + "', '" + RadioButtonList5.SelectedValue + "'),('" + null + "', '" + sid + "', '" + DropDownList1.SelectedValue + "', '" + DropDownList2.SelectedValue + "', '" + 6 + "', '" + RadioButtonList6.SelectedValue + "'),('" + null + "', '" + sid + "', '" + DropDownList1.SelectedValue + "', '" + DropDownList2.SelectedValue + "', '" + 7 + "', '" + RadioButtonList7.SelectedValue + "'),('" + null + "', '" + sid + "', '" + DropDownList1.SelectedValue + "', '" + DropDownList2.SelectedValue + "', '" + 8 + "', '" + RadioButtonList8.SelectedValue + "'),('" + null + "', '" + sid + "', '" + DropDownList1.SelectedValue + "', '" + DropDownList2.SelectedValue + "', '" + 9 + "', '" + RadioButtonList9.SelectedValue + "'),('" + null + "', '" + sid + "', '" + DropDownList1.SelectedValue + "', '" + DropDownList2.SelectedValue + "', '" + 10 + "', '" + RadioButtonList10.SelectedValue + "'),('" + null + "', '" + sid + "', '" + DropDownList1.SelectedValue + "', '" + DropDownList2.SelectedValue + "', '" + 11 + "', '" + RadioButtonList11.SelectedValue + "'),('" + null + "', '" + sid + "', '" + DropDownList1.SelectedValue + "', '" + DropDownList2.SelectedValue + "', '" + 12 + "', '" + RadioButtonList12.SelectedValue + "'),('" + null + "', '" + sid + "', '" + DropDownList1.SelectedValue + "', '" + DropDownList2.SelectedValue + "', '" + 13 + "', '" + RadioButtonList13.SelectedValue + "')", connect1);
            cmd1.ExecuteNonQuery();
            connect1.Close();
            Response.Redirect("student home.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
           
        }

        void showdata()
         {
             
            string str;

            MySqlCommand com;
            MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=stes_project");

            con.Open();
            str = "SELECT* FROM student WHERE user = '" + Session["User"] + "' && pass='" + Session["pass"] + "'";
            com = new MySqlCommand(str, con);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Label2.Text = "Welcome "+ds.Tables[0].Rows[0]["name"].ToString();
            Label3.Text = ds.Tables[0].Rows[0]["studentid"].ToString();
            Label4.Text = "Student ID is  ";
            sid =Convert.ToInt32(Label3.Text);
            Label5.Text = ds.Tables[0].Rows[0]["depid"].ToString();
            sdep = Convert.ToInt32(Label5.Text);
            Label5.Text = ds.Tables[0].Rows[0]["semid"].ToString();
            ssem = Convert.ToInt32(Label5.Text);
            Label5.Text = ds.Tables[0].Rows[0]["proid"].ToString();
            spro = Convert.ToInt32(Label5.Text);

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connectstring = ("datasource=localhost;username=root;password=;database=stes_project");
            using (MySqlConnection connect = new MySqlConnection(connectstring))
            {



                connect.Open();
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT tea_sub.teacherid,teacher.name,tea_sub.subid, subject.sub_name FROM tea_sub INNER JOIN teacher on tea_sub.teacherid=teacher.teacherid INNER JOIN subject on tea_sub.subid=subject.subid WHERE subject.depid='"+sdep+"'&&subject.semid='" + ssem+"'&&subject.proid='" + spro+"'", connect);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet myDataSet = new DataSet();
                    da.Fill(myDataSet);
                    DropDownList1.DataSource = myDataSet;
                    DropDownList1.DataTextField = "name";
                    DropDownList1.DataValueField = "teacherid";

                    DropDownList1.DataBind();

                }
                {
                   

                }
                connect.Close();
                if (DropDownList1.SelectedValue == "")
                    Label6.Text = "No Teachers found in your Semester";
                else
                {
                    DropDownList1.Visible = true;
                    Button3.Visible = true;

                    Button2.Visible = false;
                }
                

            }
        }
    }
}