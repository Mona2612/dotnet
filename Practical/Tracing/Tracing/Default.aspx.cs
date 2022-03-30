using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tracing
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //bind the grid view  
            //connection string  
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4PQK2PII\SQLEXPRESS01;Initial Catalog=monika;Integrated Security=True");
            //write query  
            string query = "select * from student_info";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            //fill in dataset  
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}