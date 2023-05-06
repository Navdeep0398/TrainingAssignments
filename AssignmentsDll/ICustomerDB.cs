using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsDll
{
     public interface ICustomerDB
    {
        void AddNewCustomer(CustomerInfo customerInfo);
        void UpdateCustomer(CustomerInfo customerInfo);
        void DeleteCustomer(int cusId);
        List<CustomerInfo> GetAllCustomer();
    }
    class CustomerComponent : ICustomerDB
    {
        private readonly string STRCONNECTION = @"Data Source=W-674PY03-1;Initial Catalog=NavdeepDb;Persist Security Info=True;User ID=sa;Password=Password@12345";
        const string STRGETALL = "Select * from tblCustomer";
        const string STRADD = "Insert into tblCustomer values(@name,@address,@phone,@amt,@date)";
        const string STRDELETE = "Delete from tblCustomer where CustomerId = @id";
        const string STRUPDATE = "Update tblCustomer set CustomerName=@name,CustomerAddress=@address,CustomerPhone=@phone,CustomerBillAmt=@amt,CustomerBillDate=@date where CustomerId = @id";
        public void AddNewCustomer(CustomerInfo customerInfo)
        {
            var connection = new SqlConnection(STRCONNECTION);
            var command = new SqlCommand(STRADD, connection);
            command.Parameters.AddWithValue("@name", customerInfo.CustomerName);
            command.Parameters.AddWithValue("@address", customerInfo.CustomerAddress);
            command.Parameters.AddWithValue("@phone", customerInfo.CustomerPhone);
            command.Parameters.AddWithValue("@amt", customerInfo.CustomerBillAmt);
            command.Parameters.AddWithValue("@date", customerInfo.CustomerBillDate);
            try {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteCustomer(int cusId)
        {
            var connection = new SqlConnection(STRCONNECTION);
            var command = new SqlCommand(STRDELETE, connection);
            command.Parameters.AddWithValue("@id", cusId);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<CustomerInfo> GetAllCustomer()
        {
            List<CustomerInfo> temp = new List<CustomerInfo>();
            var connection = new SqlConnection(STRCONNECTION);
            var command = new SqlCommand(STRGETALL, connection);
            try
            {
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var row = new CustomerInfo {
                        CustomerId = Convert.ToInt32(reader[0]),
                        CustomerName = reader[1].ToString(),
                        CustomerAddress = reader[2].ToString(),
                        CustomerPhone = Convert.ToInt32(reader[3]),
                        CustomerBillAmt = Convert.ToInt32(reader[4]),
                        CustomerBillDate = reader[5].ToString()
                    };
                    temp.Add(row);
                }

            }catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        public void UpdateCustomer(CustomerInfo customerInfo)
        {
            var connection = new SqlConnection(STRCONNECTION);
            var command = new SqlCommand(STRUPDATE, connection);
            command.Parameters.AddWithValue("@id", customerInfo.CustomerId);
            command.Parameters.AddWithValue("@name", customerInfo.CustomerName);
            command.Parameters.AddWithValue("@address", customerInfo.CustomerAddress);
            command.Parameters.AddWithValue("@phone", customerInfo.CustomerPhone);
            command.Parameters.AddWithValue("@amt", customerInfo.CustomerBillAmt);
            command.Parameters.AddWithValue("@date", customerInfo.CustomerBillDate);
            try
            {
                connection.Open();
                var updatedrow = command.ExecuteNonQuery();
                if (updatedrow != 1)
                {
                    throw new Exception("No record matched to update");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
