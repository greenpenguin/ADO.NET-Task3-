using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    public interface IList_Of_DebtorDao
    {
        IEnumerable<List_Of_Debtor> GetAll();

        void Add(List_Of_Debtor value);

        void RemoveByID(int ID);
    }
}