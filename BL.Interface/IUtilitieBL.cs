using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BL.Interface
{
    public interface IUtilitieBL
    {
        IEnumerable<Utilitie> GetAll();

        void Add(Utilitie value);

        void RemoveByID(int ID);

        Utilitie GetByID(int ID);
    }
}
