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
    public class Owner_ListLogic : IOwner_ListBL
    {
        private Owner_ListDao owner_ListDao = new Owner_ListDao();
        public void Add(Owner_List value)
        {
            owner_ListDao.Add(value);
        }

        public IEnumerable<Owner_List> GetAll()
        {
            return owner_ListDao.GetAll();
        }

        public Owner_List GetByID(int ID)
        {
            return owner_ListDao.GetByID(ID);
        }

        public void RemoveByID(int ID)
        {
            owner_ListDao.RemoveByID(ID);
        }

        public int IsOwnerExists(int ID)
        {
            return owner_ListDao.IsOwnerExists(ID);
        }

        public List<string> GetApartmentByID(int ownerID)
        {
            return owner_ListDao.GetApartmentByID(ownerID);
        }

        public List<string> GetApartmentInfoByID(int ownerID)
        {
            return owner_ListDao.GetApartmentInfoByID(ownerID);
        }

        public List<string> GetInvoicesByID(int ownerID)
        {
            return owner_ListDao.GetInvoicesByID(ownerID);
        }

        public List<string> GetInvoicesInfoByID(int ownerID)
        {
            return owner_ListDao.GetInvoicesInfoByID(ownerID);
        }

        public List<string> GetDebtByID(int ownerID)
        {
            return owner_ListDao.GetDebtByID(ownerID);
        }

        public List<string> GetDebtInfoByID(int ownerID, int utilitieID)
        {
            return owner_ListDao.GetDebtInfoByID(ownerID, utilitieID);
        }
        }
}
