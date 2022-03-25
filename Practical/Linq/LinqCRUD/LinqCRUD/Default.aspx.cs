using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqCRUD
{
    public partial class Default : System.Web.UI.Page
    {
        EmployeeDataContext db = new EmployeeDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGridview();
            }
        }
        protected void BindGridview()
        {
            var result = from ed in db.EmployeeDetails
                         select new
                         {
                             Id = ed.Id,
                             Name = ed.Name,
                             Location = ed.Location,
                             Gender = ed.Gender
                         };
            GridView1.DataSource = result;
            GridView1.DataBind();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("AddNew"))
            {
                TextBox txtname = (TextBox)GridView1.FooterRow.FindControl("txtfName");
                TextBox txtlocation = (TextBox)GridView1.FooterRow.FindControl("txtfLocation");
                TextBox txtgender = (TextBox)GridView1.FooterRow.FindControl("txtfGender");
                EmployeeDetail emp = new EmployeeDetail();
                emp.Name = txtname.Text;
                emp.Location = txtlocation.Text;
                emp.Gender = txtgender.Text;
                db.EmployeeDetails.InsertOnSubmit(emp);
                db.SubmitChanges();
                lblresult.ForeColor = Color.Green;
                lblresult.Text = txtname.Text + " details inserted successfully";
                BindGridview();
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindGridview();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindGridview();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGridview();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int empid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["Id"].ToString());
            TextBox txtname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtName");
            TextBox txtlocation = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtLocation");
            TextBox txtgender = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtGender");
            EmployeeDetail emp = new EmployeeDetail();
            emp = db.EmployeeDetails.Single(x => x.Id == empid);
            emp.Name = txtname.Text;
            emp.Location = txtlocation.Text;
            emp.Gender = txtgender.Text;
            db.SubmitChanges();
            GridView1.EditIndex = -1;
            BindGridview();
            lblresult.ForeColor = Color.Green;
            lblresult.Text = txtname.Text + " details updated successfully";
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int empid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["Id"].ToString());
            string empname = GridView1.DataKeys[e.RowIndex].Values["Name"].ToString();
            EmployeeDetail emp = new EmployeeDetail();
            emp = db.EmployeeDetails.Single(x => x.Id == empid);
            db.EmployeeDetails.DeleteOnSubmit(emp);
            db.SubmitChanges();
            BindGridview();
            lblresult.ForeColor = Color.Green;
            lblresult.Text = empname + " details deleted successfully";

        }
    }
}