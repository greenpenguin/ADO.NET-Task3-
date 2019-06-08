using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class List_Of_Debtor
    {
        public int ID_Owner { get; set; }
        public int ID_Utilitie { get; set; }
        public double Owed_Amount { get; set; }

        public List_Of_Debtor()
        { }

        public List_Of_Debtor(int id_ow, int id_ut, double ow_am)
        {
            ID_Owner = id_ow;
            ID_Utilitie = id_ut;
            Owed_Amount = ow_am;
        }

        public override string ToString()
        {
            return $"ID владельца: {ID_Owner} ID услуги: {ID_Utilitie} Сумма задолжности: {Owed_Amount}";
        }
    }
}
