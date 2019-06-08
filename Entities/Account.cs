using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Account
    {
        public int ID_Account { get; set; }
        public int Invoice_Number { get; set; }
        public int ID_Utilitie { get; set; }
        public DateTime Account_Date { get; set; }
        public double Total_Amount { get; set; }
        public double Paid_Amount { get; set; }
        public int Is_Paid { get; set; }
        public double Need_To_Pay { get; set; }

        public Account()
        { }

        public Account(int inv_num, int id_ut, DateTime acc_date, double total_am, double paid_am, int is_paid, double need_to_pay)
        {
            Invoice_Number = inv_num;
            ID_Utilitie = id_ut;
            Account_Date = acc_date;
            Total_Amount = total_am;
            Paid_Amount = paid_am;
            Is_Paid = is_paid;
            Need_To_Pay = need_to_pay;
        }

        public override string ToString()
        {
            return $"ID счета за услуги: {ID_Account}. Номер квитанции: {Invoice_Number} ID услуги: {ID_Utilitie} Дата счета: {Account_Date} " +
                $"Сумма к оплате: {Total_Amount} Оплаченная сумма: {Paid_Amount} Оплачено или нет: {Is_Paid} Осталось оплатить: {Need_To_Pay}";
        }
    }
}
