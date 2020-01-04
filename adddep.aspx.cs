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
    public partial class adddep : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("main page.aspx");

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Label9.Text = "Enter Department Name";
                Label9.Visible = true;
            }
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
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `department`(`depid`, `dep`) VALUES('" + null + "','" + TextBox1.Text + "')", connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            Response.Redirect("managedepartment.aspx"); 
        }
    }
}