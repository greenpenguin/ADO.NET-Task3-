using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    public interface IInvoiceDao
    {
        IEnumerable<Invoice> GetAll();

        void Add(Invoice value);

        void RemoveByID(int ID);

        Invoice GetByID(int ID);
    }
}
