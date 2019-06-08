using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
using BL.Interface;

namespace BL
{
    public class InvoiceLogic : IInvoiceBL
    {
        private InvoiceDao invoiceDao = new InvoiceDao();
        public void Add(Invoice value)
        {
            invoiceDao.Add(value);
        }

        public IEnumerable<Invoice> GetAll()
        {
            return invoiceDao.GetAll();
        }

        public Invoice GetByID(int ID)
        {
            return invoiceDao.GetByID(ID);
        }

        public void RemoveByID(int ID)
        {
            invoiceDao.RemoveByID(ID);
        }

        public List<string> GetAccountByID(int ID)
        {
            return invoiceDao.GetAccountByID(ID);
        }

        public int IsInvoiceExists(int ID)
        {
            return invoiceDao.IsInvoiceExists(ID);
        }
    }
}
