using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Apartment
    {
        public int ID_Apartment { get; set; }
        public int Apartment_Number { get; set; }
        public int ID_House { get; set; }
        public double Apartment_Square { get; set; }
        public int ID_Owner { get; set; }
        public int Number_Of_Prescribed { get; set; }

        public Apartment()
        { }

        public Apartment(int ap_num, int id_house, double ap_sq, int id_ow, int num_of_pr)
        {
            Apartment_Number = ap_num;
            ID_House = id_house;
            Apartment_Square = ap_sq;
            ID_Owner = id_ow;
            Number_Of_Prescribed = num_of_pr;
        }

        public override string ToString()
        {
            return $"ID квартиры: {ID_Apartment}. Номер квартиры: {Apartment_Number} ID дома: {ID_House} Площадь квартиры: {Apartment_Square} " +
                $"ID владельца: {ID_Owner} Число прописанных: {Number_Of_Prescribed}";
        }
    }
}

