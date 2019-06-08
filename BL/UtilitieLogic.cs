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
    public class UtilitieLogic : IUtilitieBL
    {
        
            private UtilitieDao utilitieDao = new UtilitieDao();
            public void Add(Utilitie value)
            {
                utilitieDao.Add(value);
            }

            public IEnumerable<Utilitie> GetAll()
            {
                return utilitieDao.GetAll();
            }

            public Utilitie GetByID(int ID)
            {
                return utilitieDao.GetByID(ID);
            }

            public void RemoveByID(int ID)
            {
                utilitieDao.RemoveByID(ID);
            }

        public int IsUtilitieExists(int ID)
        {
            return utilitieDao.IsUtilitieExists(ID);
        }
    }
}
