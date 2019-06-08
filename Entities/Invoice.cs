using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Invoice
    {
        public int Invoice_Number { get; set; }
        public int ID_Owner { get; set; }
        public DateTime Invoice_Date { get; set; }
        public double Total_Amount { get; set; }
        public double Paid_Amount { get; set; }

        public Invoice()
        { }

        public Invoice(int id_ow, DateTime inv_date, double total_am, double paid_am)
        {
            ID_Owner = id_ow;
            Invoice_Date = inv_date;
            Total_Amount = total_am;
            Paid_Amount = paid_am;
        }

        public override string ToString()
        {
            return $"ID квитанции: {Invoice_Number}. ID владельца: {ID_Owner} Дата квитанции: {Invoice_Date} " +
                $"Сумма к оплате: {Total_Amount} Оплаченная сумма: {Paid_Amount}";
        }
    }
}
