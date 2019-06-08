using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Rate_ArchiveDao : BaseDAL, IRate_ArchiveDao
    {
       // private string _connectionString = @"Data Source=1-vaio;Initial Catalog=UTILITIES3;Integrated Security=True";

        public void Add(Rate_Archive value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddRate";
                cmd.Parameters.AddWithValue(@"Rate_Start_Date", value.Start_Rate_Date);
                cmd.Parameters.AddWithValue(@"Price", value.Price);

                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@ID_Rate",
                    Direction = ParameterDirection.Output
                };

                //cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Rate_Archive> GetAll()
        {
            List<Rate_Archive> rates = new List<Rate_Archive>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllRatesFromView";
                connection.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    rates.Add(new Rate_Archive
                    {
                        ID_Rate = (int)reader["ID_Rate"],
                        Start_Rate_Date = (DateTime)reader["Start_Rate_Date"],
                        Price = (double)reader["Price"]
                    });
                }
            }
            return rates;
        }

        public Rate_Archive GetByID(int ID)
        {
            Rate_Archive rates = new Rate_Archive();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetRatesByID";
                cmd.Parameters.AddWithValue(@"ID_Rate", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rates.ID_Rate = (int)reader["ID_Rate"];
                    rates.Start_Rate_Date = (DateTime)reader["Start_Rate_Date"];
                    rates.Price = (double)reader["Price"];
                }
            }
            return rates;
        }

        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveRate";
                cmd.Parameters.AddWithValue(@"ID_Rate", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int IsRateExists(int ID)
        {
            int result = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsRateExistsByID";
                cmd.Parameters.AddWithValue(@"ID_Rate", ID);
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
