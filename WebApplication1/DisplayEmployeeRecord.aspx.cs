using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DisplayEmployeeRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataSet ds = new DataSet();
                MyService.CustomerServiceClient client = new MyService.CustomerServiceClient();
                ds = client.GetCustomerRecords();
                grdEmployees.DataSource = ds;
                grdEmployees.DataBind();
            }
        }

        protected void grdEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}