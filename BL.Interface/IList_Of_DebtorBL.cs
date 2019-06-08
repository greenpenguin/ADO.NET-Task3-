using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BL.Interface
{
    public interface IList_Of_DebtorBL
    {
        IEnumerable<List_Of_Debtor> GetAll();

        void Add(List_Of_Debtor value);

        void RemoveByID(int ID);
    }
}