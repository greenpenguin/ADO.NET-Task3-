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
    public class HouseLogic : IHouseBL
    {
        private HouseDao houseDao = new HouseDao();
        public void Add(House value)
        {
            houseDao.Add(value);
        }

        public IEnumerable<House> GetAll()
        {
            return houseDao.GetAll();
        }

        public House GetByID(int ID)
        {
            return houseDao.GetByID(ID);
        }

        public void RemoveByID(int ID)
        {
            houseDao.RemoveByID(ID);
        }

        public double HouseDebtSum(int ID)
        {
            return houseDao.HouseDebtSum(ID);
        }

        public int IsHouseExists(int ID)
        {
            return houseDao.IsHouseExists(ID);
        }
    }
}
