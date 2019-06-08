using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BL.Interface
{
    public interface IInvoiceBL
    {
        IEnumerable<Invoice> GetAll();

        void Add(Invoice value);

        void RemoveByID(int ID);

        Invoice GetByID(int ID);
    }
}
