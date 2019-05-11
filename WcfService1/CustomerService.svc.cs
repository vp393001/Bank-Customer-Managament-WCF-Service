using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ICustomerService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        //C- Add Employee Record  
        public string AddCustomerRecord(Customer cus)
        {
            string result = "";
            try
            {

                SqlConnection con = new SqlConnection(/* Connection String */"");
                SqlCommand cmd = new SqlCommand();

                string Query = @"INSERT INTO tblCustomer (CusID,Name,Email,Phone,Type)  
                                               Values(@CusID,@Name,@Email,@Phone,@Type)";

                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@CusID", cus.CusID);
                cmd.Parameters.AddWithValue("@Name", cus.Name);
                cmd.Parameters.AddWithValue("@Email", cus.Email);
                cmd.Parameters.AddWithValue("@Phone", cus.Phone);
                cmd.Parameters.AddWithValue("@Type", cus.Type);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "Record Added Successfully !";
            }
            catch (FaultException fex)
            {
                result = "Error";
            }

            return result;
        }

        //Retrieve Data  
        //Retrive Record  
        public DataSet GetCustomerRecords()
        {

            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(/* Connection String */"");
                string Query = "SELECT * FROM tblCustomer";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }

            /*
            var datalist = new List<Customer>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                var cust_to_add = new Customer();
                cust_to_add.CusID = row["CusID"].ToString();
                cust_to_add.Email = row["Email"].ToString();
                cust_to_add.Phone = row["Phone"].ToString();
                cust_to_add.Name = row["Name"].ToString();
                cust_to_add.Type = row["Type"].ToString();
                datalist.Add(cust_to_add);
            }

            return datalist;
            */
            return ds;
        }


        //Delete Record  
        public string DeleteRecords(Customer cus)
        {
            string result = "";
            SqlConnection con = new SqlConnection(/* Connection String */"");
            SqlCommand cmd = new SqlCommand();
            string Query = "DELETE FROM tblCustomer Where CusID=@CusID";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@CusID", cus.CusID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            result = "Record Deleted Successfully!";
            return result;
        }

        //Search Employee Record  
        public DataSet SearchCustomerRecord(Customer cus)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(/* Connection String */"");
                string Query = "SELECT * FROM tblCustomer WHERE CusID=@CusID";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.SelectCommand.Parameters.AddWithValue("@CusID", cus.CusID);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error:  " + fex);
            }
            return ds;
        }

        //UPDATE RECORDS  
        //Update by Phone Roll   
        public string UpdateCustomerContact(Customer cus)
        {
            string result = "";
            SqlConnection con = new SqlConnection(/* Connection String */" ");
            SqlCommand cmd = new SqlCommand();

            string Query = "UPDATE tblCustomer SET Email=@Email,Phone=@Phone WHERE CusID=@CusID";

            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@CusID", cus.CusID);
            cmd.Parameters.AddWithValue("@Email", cus.Email);
            cmd.Parameters.AddWithValue("@Phone", cus.Phone);
            con.Open();
            cmd.ExecuteNonQuery();
            result = "Record Updated Successfully !";
            con.Close();
            return result;

            //return close();

        }
    }
}
