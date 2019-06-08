using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rate_Archive
    {
        public int ID_Rate { get; set; }
        public DateTime Start_Rate_Date { get; set; }
        public double Price { get; set; }

        public Rate_Archive()
        { }

        public Rate_Archive(DateTime r_s_date, double price)
        {
            Start_Rate_Date = r_s_date;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID тарифа: {ID_Rate}. Дата установки тарифа: {Start_Rate_Date} " +
                $"Цена тарифа: {Price}";
        }
    }
}
