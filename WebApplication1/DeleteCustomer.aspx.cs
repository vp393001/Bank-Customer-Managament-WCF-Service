using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DeleteCustomer : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGridData();
            }
        }

        //Bind Grid  
        public void BindGridData()
        {
            DataSet ds = new DataSet();
            MyService.CustomerServiceClient client = new MyService.CustomerServiceClient();
            ds = client.GetCustomerRecords();
            grdEmployees.DataSource = ds;
            grdEmployees.DataBind();
        }


        protected void btnDelete_Click(object sender, EventArgs e)
        {
            MyService.CustomerServiceClient client = new MyService.CustomerServiceClient();

            MyService.Customer employee = new MyService.Customer();
            employee.CusID = txtSearch.Text.Trim();
            string result = client.DeleteRecords(employee);

            if (result == "Record Deleted Successfully!")
            {
                BindGridData();
                lblSearchResult.Text = "Employee ID: " + txtSearch.Text.Trim() + "Deleted Successfully!";
            }
            else
            {
                lblSearchResult.Text = "Employee ID: " + txtSearch.Text.Trim() + "Not Found!";
            }
        }
    }
}