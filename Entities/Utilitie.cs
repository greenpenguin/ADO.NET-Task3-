using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Utilitie
    {
        public int ID_Utilitie { get; set; }
        public string Utilitie_Type { get; set; }
        public string Unit { get; set; }
        public int ID_Rate { get; set; }

        public Utilitie()
        { }

        public Utilitie(string ut_type, string unit, int id_rate)
        {
            Utilitie_Type = ut_type;
            Unit = unit;
            ID_Rate = id_rate;
        }   
        public override string ToString()
        {
            return $"ID услуги: {ID_Utilitie}. Тип услуги: {Utilitie_Type} Единицы измерения: {Unit} " +
                $"ID тарифа: {ID_Rate}";
        }
    }
}
