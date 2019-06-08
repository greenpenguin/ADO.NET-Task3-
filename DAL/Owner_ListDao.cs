using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Owner_ListDao : BaseDAL, IOwner_ListDao
    {
        //private string _connectionString = @"Data Source=1-vaio;Initial Catalog=UTILITIES3;Integrated Security=True";

        public void Add(Owner_List value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddOwner";
                cmd.Parameters.AddWithValue(@"Name", value.Name);
                cmd.Parameters.AddWithValue(@"Second_Name", value.Second_Name);
                cmd.Parameters.AddWithValue(@"Phone_Number", value.Phone_Number);

                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@ID_Owner",
                    Direction = ParameterDirection.Output
                };

                //cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Owner_List> GetAll()
        {
            List<Owner_List> owners = new List<Owner_List>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllOwnersFromView";
                connection.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    owners.Add(new Owner_List
                    {
                        ID_Owner = (int)reader["ID_Owner"],
                        Name = (string)reader["Name"],
                        Second_Name = (string)reader["Second_Name"],
                        Phone_Number = (string)reader["Phone_Number"]
                    });
                }
            }
            return owners;
        }

        public Owner_List GetByID(int ID)
        {
            Owner_List owner = new Owner_List();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetOwnerByID";
                cmd.Parameters.AddWithValue(@"ID_Owner", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    owner.ID_Owner = (int)reader["ID_Owner"];
                    owner.Name = (string)reader["Name"];
                    owner.Second_Name = (string)reader["Second_Name"];
                    owner.Phone_Number = (string)reader["Phone_Number"];
                }
            }
            return owner;
        }

        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveOwner";
                cmd.Parameters.AddWithValue(@"ID_Owner", ID);
                
                cmd.ExecuteNonQuery();
            }
        }

        public int IsOwnerExists(int ownerID)
        {
            //using (var connection = new SqlConnection(_connectionString))
            //{
            //    connection.Open();
            //    var cmd = connection.CreateCommand();
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandText = "IsOwnerExistsByID";
            //    cmd.Parameters.AddWithValue(@"ID_Owner", ownerID);
            //    var output =  cmd.ExecuteScalar();
            //    return (int)output;
            //}
            int result = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsOwnerExistsByID";
                cmd.Parameters.AddWithValue(@"ID_Owner", ownerID);
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

        public List<string> GetApartmentByID(int ownerID)
        {
            List<string> addresses = new List<string>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Owner_Address";
                cmd.Parameters.AddWithValue(@"ID_Owner", ownerID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    addresses.Add(((int)reader["Apartment_Number"]).ToString());
                    addresses.Add((string)reader["Adress"]);
                }
            }
            return addresses;
        }

        public List<string> GetApartmentInfoByID(int ownerID)
        {
            List<string> information = new List<string>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Owner_Info";
                cmd.Parameters.AddWithValue(@"ID_Owner", ownerID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    information.Add(((double)reader["Apartment_Square"]).ToString());
                    information.Add(((int)reader["Number_Of_Prescribed"]).ToString());
                }
            }
            return information;
        }

        public List<string> GetInvoicesByID(int ownerID)
        {
            List<string> information = new List<string>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Invoices_List";
                cmd.Parameters.AddWithValue(@"ID_Owner", ownerID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    information.Add(((int)reader["Invoice_Number"]).ToString());
                }
            }
            return information;
        }

        public List<string> GetInvoicesInfoByID(int ownerID)
        {
            List<string> information = new List<string>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Invoices_Info";
                cmd.Parameters.AddWithValue(@"ID_Owner", ownerID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {//Invoice_Date, Total_Amount, Paid_Amount
                    information.Add(((DateTime)reader["Invoice_Date"]).ToString());
                    information.Add(((double)reader["Total_Amount"]).ToString());
                    information.Add(((double)reader["Paid_Amount"]).ToString());
                    double need_to_pay = (double)reader["Total_Amount"] -(double)reader["Paid_Amount"];
                    information.Add(need_to_pay.ToString());

                }
            }
            return information;
        }

        public List<string> GetDebtByID(int ownerID)
        {
            List<string> information = new List<string>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetDebpByID";
                cmd.Parameters.AddWithValue(@"ID_Owner", ownerID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    information.Add(((double)reader["Owed_Amount"]).ToString());
                    information.Add(((int)reader["ID_Utilitie"]).ToString());
                }
            }
            return information;
        }

        

        public List<string> GetDebtInfoByID(int ownerID, int utilitieID)
        {
            List<string> information = new List<string>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetDebpInfoByID";
                cmd.Parameters.AddWithValue(@"ID_Owner", ownerID);
                cmd.Parameters.AddWithValue(@"ID_Utilitie", utilitieID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    information.Add((string)reader["Utilitie_Type"]);
                    information.Add(((double)reader["Owed_Amount"]).ToString());
                }
            }
            return information;
        }
    }
}
