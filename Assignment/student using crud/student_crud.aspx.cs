using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace student
{
    public partial class student_crud : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4PQK2PII\SQLEXPRESS01; Initial Catalog=crud_operation; Integrated Security=True");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            btnupdate.Enabled = false;
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into students_crud values(@rollno,@name,@address,@course)", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.Parameters.AddWithValue("@rollno", txtroll.Text);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@course", txtcourse.Text);
                cmd.ExecuteNonQuery();
                Label1.Text = "Data has been saved";
                con.Close();
                txtroll.Text = "";
                txtname.Text = "";
                txtaddress.Text = "";
                txtcourse.Text = "";
            }
            catch
            {
                Label1.Text = "First Search Data";
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update students_crud set name=@name,course=@course,address=@address where rollno=@rollno", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@course", txtcourse.Text);
            cmd.Parameters.AddWithValue("@address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@rollno", txtroll.Text);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Label1.Text = "Data has been Updated";
            con.Close();
            txtroll.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            txtcourse.Text = "";
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from students_crud where rollno=" + txtroll.Text, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Label2.Text = "rollno is Found Successfully";
                Label1.Text = "";
                txtname.Text = ds.Tables[0].Rows[0]["name"].ToString();
                txtaddress.Text = ds.Tables[0].Rows[0]["address"].ToString();
                txtcourse.Text = ds.Tables[0].Rows[0]["course"].ToString();
                btnupdate.Enabled = true;
            }
            else
            {
                Label2.Text = "No Particular Searched rollno  Found";
            }
            con.Close();
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("delete from students_crud where rollno=" + txtname.Text, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Label1.Text = "Data has been Deleted";
                    con.Close();
                    txtroll.Text = "";
                    txtname.Text = "";
                    txtaddress.Text = "";
                    txtcourse.Text = "";
                }
                catch
                {
                    Label1.Text = " invalid Please select rollno First ";
                }
            }
        }

        protected void btnviews_Click(object sender, EventArgs e)
        {
            SqlDataAdapter Adp = new SqlDataAdapter("select * from students_crud", con);
            //DataTable Dt = new DataTable()
            DataSet ds = new DataSet();
            Adp.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }

}





    