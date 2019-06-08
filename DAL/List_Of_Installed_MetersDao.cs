using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class List_Of_Installed_MetersDao : BaseDAL, IList_Of_Installed_MetersDao
    {
       // private string _connectionString = @"Data Source=1-vaio;Initial Catalog=UTILITIES3;Integrated Security=True";

        public void Add(List_Of_Installed_Meters value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddInstalledMeter";
                cmd.Parameters.AddWithValue(@"ID_Meter", value.ID_Meter);
                cmd.Parameters.AddWithValue(@"Date", value.Date);
                cmd.Parameters.AddWithValue(@"Meter_Reading", value.Meter_Reading);
                
                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Record_Number",
                    Direction = ParameterDirection.Output
                };

                //cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<List_Of_Installed_Meters> GetAll()
        {
            List<List_Of_Installed_Meters> installed_meters = new List<List_Of_Installed_Meters>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllInstalledMeterFromView";
                connection.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    installed_meters.Add(new List_Of_Installed_Meters
                    {//ID_Meter, Today_Date, Meter_Reading_For_Today_Date
                        Record_Number = (int)reader["Record_Number"],
                        ID_Meter = (int)reader["ID_Meter"],
                        Date = (DateTime)reader["Today_Date"],
                        Meter_Reading = (double)reader["Meter_Reading_For_Today_Date"]
                    });
                }
            }
            return installed_meters;
        }

        public List_Of_Installed_Meters GetByID(int ID)
        {
            List_Of_Installed_Meters installed_meters = new List_Of_Installed_Meters();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetInstalledMeterByID";
                cmd.Parameters.AddWithValue(@"Record_Number", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    installed_meters.Record_Number = (int)reader["Record_Number"];
                    installed_meters.ID_Meter = (int)reader["ID_Meter"];
                    installed_meters.Date = (DateTime)reader["Today_Date"];
                    installed_meters.Meter_Reading = (double)reader["Meter_Reading_For_Today_Date"];
                }
            }
            return installed_meters;
        }

        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveInstalledMeter";
                cmd.Parameters.AddWithValue(@"Record_Number", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int IsInstMeterExists(int ID)
        {
            int result = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsInstMeterExistsByID";
                cmd.Parameters.AddWithValue(@"Record_Number", ID);
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
