using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    public interface IHouseDao
    {
        IEnumerable<House> GetAll();

        void Add(House value);

        void RemoveByID(int ID);

        House GetByID(int ID);
    }
}

