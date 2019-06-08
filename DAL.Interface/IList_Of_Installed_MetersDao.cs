using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    public interface IList_Of_Installed_MetersDao
    {
        IEnumerable<List_Of_Installed_Meters> GetAll();

        void Add(List_Of_Installed_Meters value);

        void RemoveByID(int ID);

        List_Of_Installed_Meters GetByID(int ID);
    }
}