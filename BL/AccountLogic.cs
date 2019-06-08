using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
using BL.Interface;

namespace BL
{
    public class AccountLogic : IAccountBL
    {
        private AccountDao accountDao = new AccountDao();
        public void Add(Account value)
        {
            accountDao.Add(value);
        }

        public IEnumerable<Account> GetAll()
        {
            return accountDao.GetAll();
        }

        public Account GetByID(int ID)
        {
            return accountDao.GetByID(ID);
        }

        public void RemoveByID(int ID)
        {
            accountDao.RemoveByID(ID);
        }

        public List<string> GetAccountInfoByID(int accountID)
        {
            return accountDao.GetAccountInfoByID(accountID);
        }

        public int IsAccountExists(int ID)
        {
            return accountDao.IsAccountExists(ID);
        }
    }
}

