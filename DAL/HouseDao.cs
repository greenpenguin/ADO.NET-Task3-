using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class HouseDao : BaseDAL, IHouseDao
    {
        //private string _connectionString = @"Data Source=1-vaio;Initial Catalog=UTILITIES3;Integrated Security=True";

        public void Add(House value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddHouse";
                cmd.Parameters.AddWithValue(@"Address", value.Address);

                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@ID_House",
                    Direction = ParameterDirection.Output
                };

                //cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<House> GetAll()
        {
            List<House> houses = new List<House>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllHousesFromView";
                connection.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    houses.Add(new House
                    {
                        ID_House = (int)reader["ID_House"],
                        Address = (string)reader["Adress"]
                    });
                }
            }
            return houses;
        }

        public House GetByID(int ID)
        {
            House house = new House();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetHouseByID";
                cmd.Parameters.AddWithValue(@"ID_House", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    house.ID_House = (int)reader["ID_House"];
                    house.Address = (string)reader["Adress"];
                }
            }
            return house;
        }

        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveHouse";
                cmd.Parameters.AddWithValue(@"ID_House", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public double HouseDebtSum(int ID)
        {
            double result = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "HouseDebtSum";
                cmd.Parameters.AddWithValue(@"house_id", ID);
                var output = new SqlParameter
                {
                    DbType = DbType.Double,
                    ParameterName = "@sumP",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(output);
                connection.Open();
                cmd.ExecuteNonQuery();
                if (output.Value is double)
                {
                    return result = (double)output.Value;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int IsHouseExists(int ID)
        {
            int result = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsHouseExists";
                cmd.Parameters.AddWithValue(@"ID_House", ID);
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
