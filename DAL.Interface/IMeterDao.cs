using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    public interface IMeterDao
    {
        IEnumerable<Meter> GetAll();

        void Add(Meter value);

        void RemoveByID(int ID);

        Meter GetByID(int ID);
    }
}

