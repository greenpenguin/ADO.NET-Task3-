using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BL.Interface
{
    public interface IAccountBL
    {
        IEnumerable<Account> GetAll();

        void Add(Account value);

        void RemoveByID(int ID);

        Account GetByID(int ID);
    }
}
