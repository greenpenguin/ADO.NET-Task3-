using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class List_Of_Installed_Meters
    {
        public int Record_Number { get; set; }
        public int ID_Meter { get; set; }
        public DateTime Date { get; set; }
        public double Meter_Reading { get; set; }

        public List_Of_Installed_Meters()
        { }

        public List_Of_Installed_Meters(int id_meter, DateTime date, double meter_reading)
        {
            ID_Meter = id_meter;
            Date = date;
            Meter_Reading = meter_reading;
        }

        public override string ToString()
        {
            return $"Номер записи: {Record_Number}. ID счетчика: {ID_Meter} Дата снятия показаний: {Date} Показания счетчика: {Meter_Reading}";
        }
    }
}
