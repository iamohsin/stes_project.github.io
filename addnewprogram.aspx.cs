﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace mas
{
    public partial class addnewprogram : System.Web.UI.Page
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
        } }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Label9.Text = "Enter Program Name";
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
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `program`(`proid`, `pro`, `depid`) VALUES('" + null + "','" + TextBox1.Text + "','" +DropDownList1.SelectedValue + "')", connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            Response.Redirect("Manege Program.aspx");
        }
    


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}