using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MeterDao : BaseDAL, IMeterDao
    {
        //private string _connectionString = @"Data Source=1-vaio;Initial Catalog=UTILITIES3;Integrated Security=True";

        public void Add(Meter value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddMeter";
                cmd.Parameters.AddWithValue(@"Installation_Date", value.Installation_Date);
                cmd.Parameters.AddWithValue(@"Next_Check_Date", value.Next_Check_Date);
                cmd.Parameters.AddWithValue(@"ID_Utilitie", value.ID_Utilitie);

                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@ID_Meter",
                    Direction = ParameterDirection.Output
                };

                //cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Meter> GetAll()
        {
            List<Meter> meters = new List<Meter>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllMetersFromView";
                connection.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    meters.Add(new Meter
                    {
                        ID_Meter = (int)reader["ID_Meter"],
                        Installation_Date = (DateTime)reader["Installation_Date"],
                        Next_Check_Date = (DateTime)reader["Next_Check_Date"],
                        ID_Utilitie = (int)reader["ID_Utilitie"]
                    });
                }
            }
            return meters;
        }

        public Meter GetByID(int ID)
        {
            Meter meter = new Meter();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetMeterByID";
                cmd.Parameters.AddWithValue(@"ID_Meter", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    meter.ID_Meter = (int)reader["ID_Meter"];
                    meter.Installation_Date = (DateTime)reader["Installation_Date"];
                    meter.Next_Check_Date = (DateTime)reader["Next_Check_Date"];
                    meter.ID_Utilitie = (int)reader["ID_Utilitie"];
                }
            }
            return meter;
        }

        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveMeter";
                cmd.Parameters.AddWithValue(@"ID_Meter", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int IsMeterExists(int ID)
        {
            int result = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsMeterExistsByID";
                cmd.Parameters.AddWithValue(@"ID_Meter", ID);
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
