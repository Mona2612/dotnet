using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace regform
{
    public partial class registrationform : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4PQK2PII\SQLEXPRESS01; Initial Catalog=regestrationform; Integrated Security=True");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                FillGrid();
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfirstname.Text == null || txtaddress.Text == null || txtusername.Text == null ||// add more coloum
               txtemail.Text==null || txtpassword.Text==null)
                    lblInfo.Text = "Please enter all fields";
                else
                {

                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "sp_regs";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text.ToString());
                    cmd.Parameters.AddWithValue("@LastName ", txtlastname.Text.ToString());
                    cmd.Parameters.AddWithValue("@Gender", radiobtngender.Text.ToString());
                    cmd.Parameters.AddWithValue("@Address", txtaddress.Text.ToString());
                    cmd.Parameters.AddWithValue("@City", ddlcity.SelectedValue);
                    cmd.Parameters.AddWithValue("@State", ddlstate.SelectedValue);
                    cmd.Parameters.AddWithValue("@UserName", txtusername.Text.ToString());
                    cmd.Parameters.AddWithValue("@Email ", txtemail.Text.ToString());
                    cmd.Parameters.AddWithValue("@Password ", txtpassword.Text.ToString());// add more parameter for coloum
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("Select FirstName,LastName,Gender,Address,City,State,UserName,Email,Password", con));
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    progridview.DataSource = dt;
                    progridview.DataBind();
                    adapter.Dispose();
                    cmd.Dispose();
                    con.Close();

                    lblInfo.Text = "Added Successfully";
                    txtfirstname.Text = "";
                    txtlastname.Text = "";
                    radiobtngender.Text = "";
                    txtaddress.Text = "";
                    ddlcity.SelectedValue = "";
                    ddlstate.SelectedValue = "";
                    txtusername.Text = "";
                    txtemail.Text = "";
                    txtpassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Error:" + ex.Message.ToString();
            }
        }

        public void FillGrid()
        {
            try
            {

                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("Select  FirstName,LastName,Gender,Address,City,State,UserName,Email,Password from regs_form", con)); ///
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                progridview.DataSource = dt;
                progridview.DataBind();
                adapter.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}