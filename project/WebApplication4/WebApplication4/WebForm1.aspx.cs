using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection SQLConn = new SqlConnection(@"Data Source=LAPTOP-4PQK2PII\SQLEXPRESS01; Initial Catalog=monika; Integrated Security=True");
            lblmsg.Text = "";
            SqlDataAdapter SQLAdapter = new SqlDataAdapter("Select * from Table_1 where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", SQLConn);
            DataTable DT = new DataTable();
            SQLAdapter.Fill(DT);

            if (DT.Rows.Count > 0)
            {
                lblmsg.Text = "Welcome to System";
                lblmsg.ForeColor = System.Drawing.Color.Green;
            }

            else
            {
                lblmsg.Text = "Invalid username or password";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}