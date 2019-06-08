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
    public class List_Of_DebtorLogic : IList_Of_DebtorBL
    {
        private List_Of_DebtorDao list_Of_DebtorDao = new List_Of_DebtorDao();
        public void Add(List_Of_Debtor value)
        {
            list_Of_DebtorDao.Add(value);
        }

        public IEnumerable<List_Of_Debtor> GetAll()
        {
            return list_Of_DebtorDao.GetAll();
        }

        public void RemoveByID(int ID)
        {
            list_Of_DebtorDao.RemoveByID(ID);
        }

        public List_Of_Debtor GetByID(int ownerID, int utilitieID)
        {
            return list_Of_DebtorDao.GetByID(ownerID, utilitieID);
        }
        }
}
