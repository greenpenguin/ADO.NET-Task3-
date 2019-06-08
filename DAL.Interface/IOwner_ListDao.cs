using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    public interface IOwner_ListDao
    {
        IEnumerable<Owner_List> GetAll();

        void Add(Owner_List value);

        void RemoveByID(int ID);

        Owner_List GetByID(int ID);
    }
}
