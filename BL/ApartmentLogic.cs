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
    public class ApartmentLogic : IApartmentBL
    {
        private ApartmentDao apartmentDao = new ApartmentDao();
        public void Add(Apartment value)
        {
            apartmentDao.Add(value);
        }

        public IEnumerable<Apartment> GetAll()
        {
            return apartmentDao.GetAll();
        }

        public Apartment GetByID(int ID)
        {
            return apartmentDao.GetByID(ID);
        }

        public void RemoveByID(int ID)
        {
            apartmentDao.RemoveByID(ID);
        }

        public int IsApartmentExists(int ID)
        {
            return apartmentDao.IsApartmentExists(ID);
        }
    }
}