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
    public class List_Of_Installed_MetersLogic : IList_Of_Installed_MetersBL
    {
        private List_Of_Installed_MetersDao list_Of_Installed_MetersDao = new List_Of_Installed_MetersDao();
        public void Add(List_Of_Installed_Meters value)
        {
            list_Of_Installed_MetersDao.Add(value);
        }

        public IEnumerable<List_Of_Installed_Meters> GetAll()
        {
            return list_Of_Installed_MetersDao.GetAll();
        }

        public List_Of_Installed_Meters GetByID(int ID)
        {
            return list_Of_Installed_MetersDao.GetByID(ID);
        }

        public void RemoveByID(int ID)
        {
            list_Of_Installed_MetersDao.RemoveByID(ID);
        }

        public int IsInstMeterExists(int ID)
        {
            return list_Of_Installed_MetersDao.IsInstMeterExists(ID);
        }
    }
}
