using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AccountDao : BaseDAL, IAccountDao
    {
        public AccountDao()
        {

        }
        //private string _connectionString = @"Data Source=1-vaio;Initial Catalog=UTILITIES3;Integrated Security=True";

        public void Add(Account value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddAccount";
                cmd.Parameters.AddWithValue(@"Invoice_Number", value.Invoice_Number);
                cmd.Parameters.AddWithValue(@"ID_Utilitie", value.ID_Utilitie);
                cmd.Parameters.AddWithValue(@"Account_Date", value.Account_Date);
                cmd.Parameters.AddWithValue(@"Total_Amount", value.Total_Amount);
                cmd.Parameters.AddWithValue(@"Paid_Amount", value.Paid_Amount);
                cmd.Parameters.AddWithValue(@"Is_Paid", value.Is_Paid);
                cmd.Parameters.AddWithValue(@"Need_To_Pay", value.Need_To_Pay);
                
                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@ID_Account",
                    Direction = ParameterDirection.Output
                };

                //cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Account> GetAll()
        {
            List<Account> account = new List<Account>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllAccountsFromView";
                connection.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    account.Add(new Account
                    {//Invoice_Number, ID_Utilitie, Account_Date, Total_Amount, Paid_Amount, Is_Paid, Need_To_Pay
                        ID_Account = (int)reader["ID_Account"],
                        Invoice_Number = (int)reader["Invoice_Number"],
                        ID_Utilitie = (int)reader["ID_Utilitie"],
                        Account_Date = (DateTime)reader["Account_Date"],
                        Total_Amount = (double)reader["Total_Amount"],
                        Paid_Amount = (double)reader["Paid_Amount"],
                        Is_Paid = (int)reader["Is_Paid"],
                        Need_To_Pay = (double)reader["Need_To_Pay"]
                    });
                }
            }
            return account;
        }

        public Account GetByID(int ID)
        {
            Account account = new Account();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAccountID";
                cmd.Parameters.AddWithValue(@"ID_Account", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    account.ID_Account = (int)reader["ID_Account"];
                    account.Invoice_Number = (int)reader["Invoice_Number"];
                    account.ID_Utilitie = (int)reader["ID_Utilitie"];
                    account.Account_Date = (DateTime)reader["Account_Date"];
                    account.Total_Amount = (double)reader["Total_Amount"];
                    account.Paid_Amount = (double)reader["Paid_Amount"];
                    account.Is_Paid = (int)reader["Is_Paid"];
                    account.Need_To_Pay = (double)reader["Need_To_Pay"];
                }
            }
            return account;
        }

        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveAccount";
                cmd.Parameters.AddWithValue(@"ID_Account", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //GetAccountInfoByID
        public List<string> GetAccountInfoByID(int accountID)
        {
            List<string> information = new List<string>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAccountInfoByID";
                cmd.Parameters.AddWithValue(@"id_Account", accountID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {//@util_type AS [Utilitie_Type], Account_Date, Total_Amount, Paid_Amount is_paid need_to_pay
                    information.Add((string)reader["Utilitie_Type"]);
                    information.Add(((DateTime)reader["Account_Date"]).ToString());
                    information.Add(((double)reader["Total_Amount"]).ToString());
                    information.Add(((double)reader["Paid_Amount"]).ToString());
                    double need_to_pay = (double)reader["Total_Amount"] - (double)reader["Paid_Amount"];
                    if (need_to_pay == 0)
                    {
                        information.Add("Yes");
                    }
                    else
                    {
                        information.Add("No");
                    }
                    information.Add(need_to_pay.ToString());

                }
            }
            return information;
        }

        public int IsAccountExists(int ID)
        {
            int result = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsAccountExistsByID";
                cmd.Parameters.AddWithValue(@"ID_Account", ID);
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
