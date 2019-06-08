using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ApartmentDao : BaseDAL, IApartmentDao
    {
        //private string _connectionString = @"Data Source=1-vaio;Initial Catalog=UTILITIES3;Integrated Security=True";

        public void Add(Apartment value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddApartment";
                cmd.Parameters.AddWithValue(@"Apartment_Number", value.Apartment_Number);
                cmd.Parameters.AddWithValue(@"ID_House", value.ID_House);
                cmd.Parameters.AddWithValue(@"Apartment_Square", value.Apartment_Square);
                cmd.Parameters.AddWithValue(@"ID_Owner", value.ID_Owner);
                cmd.Parameters.AddWithValue(@"Number_Of_Prescribed", value.Number_Of_Prescribed);
                
                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@ID_Apartment",
                    Direction = ParameterDirection.Output
                };

                //cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Apartment> GetAll()
        {
            List<Apartment> apartments = new List<Apartment>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllApartmentFromView";
                connection.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    apartments.Add(new Apartment
                    {
                        ID_Apartment = (int)reader["ID_Apartment"],
                        Apartment_Number = (int)reader["Apartment_Number"],
                        ID_House = (int)reader["ID_House"],
                        Apartment_Square = (double)reader["Apartment_Square"],
                        ID_Owner = (int)reader["ID_Owner"],
                        Number_Of_Prescribed = (int)reader["Number_Of_Prescribed"]
                    });
                }
            }
            return apartments;
        }

        public Apartment GetByID(int ID)
        {
            Apartment apartment = new Apartment();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetApartmentID";
                cmd.Parameters.AddWithValue(@"ID_Apartment", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    apartment.ID_Apartment = (int)reader["ID_Apartment"];
                    apartment.Apartment_Number = (int)reader["Apartment_Number"];
                    apartment.ID_House = (int)reader["ID_House"];
                    apartment.Apartment_Square = (double)reader["Apartment_Square"];
                    apartment.ID_Owner = (int)reader["ID_Owner"];
                    apartment.Number_Of_Prescribed = (int)reader["Number_Of_Prescribed"];
                }
            }
            return apartment;
        }

        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveApartment";
                cmd.Parameters.AddWithValue(@"ID_Apartment", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int IsApartmentExists(int ID)
        {
            int result = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsApartmentExistsByID";
                cmd.Parameters.AddWithValue(@"ID_Apartment", ID);
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
