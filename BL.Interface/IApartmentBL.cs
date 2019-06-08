using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BL.Interface
{
    public interface IApartmentBL
    {
        IEnumerable<Apartment> GetAll();

        void Add(Apartment value);

        void RemoveByID(int ID);

        Apartment GetByID(int ID);
    }
}

