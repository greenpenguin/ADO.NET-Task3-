using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BL.Interface
{
    public interface IRate_ArchiveBL
    {
        IEnumerable<Rate_Archive> GetAll();

        void Add(Rate_Archive value);

        void RemoveByID(int ID);

        Rate_Archive GetByID(int ID);
    }
}