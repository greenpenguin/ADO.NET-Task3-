using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class InvoiceDao : BaseDAL, IInvoiceDao
    {
        //private string _connectionString = @"Data Source=1-vaio;Initial Catalog=UTILITIES3;Integrated Security=True";

        public void Add(Invoice value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddInvoice";
                cmd.Parameters.AddWithValue(@"ID_Owner", value.ID_Owner);
                cmd.Parameters.AddWithValue(@"Invoice_Date", value.Invoice_Date);
                cmd.Parameters.AddWithValue(@"Total_Amount", value.Total_Amount);
                cmd.Parameters.AddWithValue(@"Paid_Amount", value.Paid_Amount);
                
                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Invoice_Number",
                    Direction = ParameterDirection.Output
                };

                //cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Invoice> GetAll()
        {
            List<Invoice> invoices = new List<Invoice>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllInvoiceFromView";
                connection.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    invoices.Add(new Invoice
                    {
                        Invoice_Number = (int)reader["Invoice_Number"],
                        ID_Owner = (int)reader["ID_Owner"],
                        Invoice_Date = (DateTime)reader["Invoice_Date"],
                        Total_Amount = (double)reader["Total_Amount"],
                        Paid_Amount = (double)reader["Paid_Amount"]
                    });
                }
            }
            return invoices;
        }

        public Invoice GetByID(int ID)
        {
            Invoice invoice = new Invoice();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetInvoiceID";
                cmd.Parameters.AddWithValue(@"ID_Invoice", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    invoice.Invoice_Number = (int)reader["Invoice_Number"];
                    invoice.ID_Owner = (int)reader["ID_Owner"];
                    invoice.Invoice_Date = (DateTime)reader["Invoice_Date"];
                    invoice.Total_Amount = (double)reader["Total_Amount"];
                    invoice.Paid_Amount = (double)reader["Paid_Amount"];
                }
            }
            return invoice;
        }

        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveInvoice";
                cmd.Parameters.AddWithValue(@"Invoice_Number", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<string> GetAccountByID(int invoiceID)
        {
            List<string> information = new List<string>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAccountByID";
                cmd.Parameters.AddWithValue(@"id_Invoice", invoiceID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    information.Add(((int)reader["ID_Account"]).ToString());
                }
            }
            return information;
        }

        public int IsInvoiceExists(int ID)
        {
            int result = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsInvoiceExistsByID";
                cmd.Parameters.AddWithValue(@"Invoice_Number", ID);
                var output = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@result",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(output);
                connection.Open();
                cmd.ExecuteNonQuery();
                if (output.Value is int)
                {
                    return result = (int)output.Value;
                }
                else
                {
                    return 0;
                }

            }
        }


    }
}
