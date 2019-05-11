using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AddNewEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtCusID.Text = "";
                txtName.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                lblMsg.Text = "";
                txtCusID.Focus();
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //Adding New Employee Records  

            if ((txtCusID.Text != "") || (txtName.Text != "") || (txtEmail.Text != "") || (txtPhone.Text != ""))
            {
                try
                {
                    MyService.Customer customer = new MyService.Customer();
                    customer.CusID = txtCusID.Text;
                    customer.Name = txtName.Text;
                    customer.Email = txtEmail.Text;
                    customer.Phone = txtPhone.Text;
                    customer.Type = rbtnGender.SelectedItem.Text;

                    MyService.CustomerServiceClient client = new MyService.CustomerServiceClient();
                    lblMsg.Text = "Employee ID: " + customer.CusID + ", " + client.AddCustomerRecord(customer);
                }
                catch (Exception ex)
                {
                    lblMsg.Text = "Employee ID must be unique! " + ex;
                }


            }
            else
            {

                lblMsg.Text = "All fields are mandatory! ";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }


        }

        protected void bntReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtCusID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            lblMsg.Text = "";
            txtCusID.Focus();
        }
    }
}