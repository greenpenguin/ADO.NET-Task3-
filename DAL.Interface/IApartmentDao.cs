using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    public interface IApartmentDao
    {
        IEnumerable<Apartment> GetAll();

        void Add(Apartment value);

        void RemoveByID(int ID);

        Apartment GetByID(int ID);
    }
}

