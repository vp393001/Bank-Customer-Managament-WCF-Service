using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string AddCustomerRecord(Customer cus);

        [OperationContract]
        DataSet GetCustomerRecords();

        [OperationContract]
        string DeleteRecords(Customer cus);

        [OperationContract]
        DataSet SearchCustomerRecord(Customer cus);

        [OperationContract]
        string UpdateCustomerContact(Customer cus);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Customer
    {
        string _cusID = "";
        string _name = "";
        string _email = "";
        string _phone = "";
        string _type = "";

        [DataMember]
        public string CusID
        {
            get { return _cusID; }
            set { _cusID = value; }
        }

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        [DataMember]
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        [DataMember]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

    }
}

