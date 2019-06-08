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
    public class Rate_ArchiveLogic : IRate_ArchiveBL
    {
        private Rate_ArchiveDao rate_ArchiveDao = new Rate_ArchiveDao();
            public void Add(Rate_Archive value)
            {
                rate_ArchiveDao.Add(value);
            }

            public IEnumerable<Rate_Archive> GetAll()
            {
                return rate_ArchiveDao.GetAll();
            }

            public Rate_Archive GetByID(int ID)
            {
                return rate_ArchiveDao.GetByID(ID);
            }

            public void RemoveByID(int ID)
            {
                rate_ArchiveDao.RemoveByID(ID);
            }

        public int IsRateExists(int ID)
        {
            return rate_ArchiveDao.IsRateExists(ID);
        }

    }
    
}
