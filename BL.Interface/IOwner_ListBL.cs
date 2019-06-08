using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BL.Interface
{
    public interface IOwner_ListBL
    {
        IEnumerable<Owner_List> GetAll();

        void Add(Owner_List value);

        void RemoveByID(int ID);

        Owner_List GetByID(int ID);
    }
}
