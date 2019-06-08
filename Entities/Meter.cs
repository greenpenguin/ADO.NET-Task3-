using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Meter
    {
        public int ID_Meter { get; set; }
        public DateTime Installation_Date { get; set; }
        public DateTime Next_Check_Date { get; set; }
        public int ID_Utilitie { get; set; }

        public Meter()
        { }

        public Meter(DateTime in_date, DateTime n_ch_date, int id_ut)
        {
            Installation_Date = in_date;
            Next_Check_Date = n_ch_date;
            ID_Utilitie = id_ut;
        }

        public override string ToString()
        {
            return $"ID счетчика: {ID_Meter}. ID услуги: {ID_Utilitie} Дата установки счетчика: {Installation_Date} " +
                $"Дата следующей проверки счетчика: {Next_Check_Date}";
        }
    }
}
