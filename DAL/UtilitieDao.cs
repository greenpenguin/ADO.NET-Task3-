using DAL.Interface;
using Entities;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UtilitieDao : BaseDAL, IUtilitieDao
    {
        //private string _connectionString = @"Data Source=1-vaio;Initial Catalog=UTILITIES3;Integrated Security=True";

        public void Add(Utilitie value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddUtilitie";
                cmd.Parameters.AddWithValue(@"Utilitie_Type", value.Utilitie_Type);
                cmd.Parameters.AddWithValue(@"Unit", value.Unit);
                cmd.Parameters.AddWithValue(@"ID_Rate", value.ID_Rate);

                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@ID_Utilitie",
                    Direction = ParameterDirection.Output
                };

                //cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Utilitie> GetAll()
        {
            List<Utilitie> utilities = new List<Utilitie>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllUtilitieFromView";
                connection.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    utilities.Add(new Utilitie
                    {
                        ID_Utilitie = (int)reader["ID_Utilitie"],
                        Utilitie_Type = (string)reader["Utilitie_Type"],
                        Unit = (string)reader["Unit"],
                        ID_Rate = (int)reader["ID_Rate"]
                    });
                }
            }
            return utilities;
        }

        public Utilitie GetByID(int ID)
        {
            Utilitie utilitie = new Utilitie();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetUtilitieByID";
                cmd.Parameters.AddWithValue(@"ID_Utilitie", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    utilitie.ID_Utilitie = (int)reader["ID_Utilitie"];
                    utilitie.Utilitie_Type = (string)reader["Utilitie_Type"];
                    utilitie.Unit = (string)reader["Unit"];
                    utilitie.ID_Rate = (int)reader["ID_Rate"];
                }
            }
            return utilitie;
        }

        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveUtilitie";
                cmd.Parameters.AddWithValue(@"ID_Utilitie", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int IsUtilitieExists(int ID)
        {
            int result = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsUtilitieExistsByID";
                cmd.Parameters.AddWithValue(@"ID_Utilitie", ID);
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