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
    public class MeterLogic : IMeterBL
    {
            private MeterDao metersDao = new MeterDao();
            public void Add(Meter value)
            {
                metersDao.Add(value);
            }

            public IEnumerable<Meter> GetAll()
            {
                return metersDao.GetAll();
            }

            public Meter GetByID(int ID)
            {
                return metersDao.GetByID(ID);
            }

            public void RemoveByID(int ID)
            {
                metersDao.RemoveByID(ID);
            }

        public int IsMeterExists(int ID)
        {
            return metersDao.IsMeterExists(ID);
        }
    }
}
