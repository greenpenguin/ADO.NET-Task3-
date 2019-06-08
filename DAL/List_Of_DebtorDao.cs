using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class List_Of_DebtorDao : BaseDAL, IList_Of_DebtorDao
    {
        //private string _connectionString = @"Data Source=1-vaio;Initial Catalog=UTILITIES3;Integrated Security=True";

        public void Add(List_Of_Debtor value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddDebtor";
                cmd.Parameters.AddWithValue(@"ID_Owner", value.ID_Owner);
                cmd.Parameters.AddWithValue(@"ID_Utilitie", value.ID_Utilitie);
                cmd.Parameters.AddWithValue(@"Owed_Amount", value.Owed_Amount);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List_Of_Debtor GetByID(int ownerID, int utilitieID)
        {
            List_Of_Debtor debtors = new List_Of_Debtor();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetDebtByID";
                cmd.Parameters.AddWithValue(@"ID_Owner", ownerID);
                cmd.Parameters.AddWithValue(@"ID_Utilitie", utilitieID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    debtors.ID_Owner = (int)reader["ID_Owner"];
                    debtors.ID_Utilitie = (int)reader["ID_Utilitie"];
                    debtors.Owed_Amount = (double)reader["Owed_Amount"];
                }
            }
            return debtors;
        }

        public IEnumerable<List_Of_Debtor> GetAll()
        {
            List<List_Of_Debtor> debtors = new List<List_Of_Debtor>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllList_Of_Debtor";
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    debtors.Add(new List_Of_Debtor
                    {//ID_Owner, ID_Utilitie, Owed_Amount
                        ID_Owner = (int)reader["ID_Owner"],
                        ID_Utilitie = (int)reader["ID_Utilitie"],
                        Owed_Amount = (double)reader["Owed_Amount"]
                    });
                }
            }
            return debtors;
        }

        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveList_Of_Debtor";
                cmd.Parameters.AddWithValue(@"ID_Owner", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
