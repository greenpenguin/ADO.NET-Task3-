using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Owner_List
    {
        public int ID_Owner { get; set; }
        public string Name { get; set; }
        public string Second_Name { get; set; }
        public string Phone_Number { get; set; }

        public Owner_List()
        { }

        public Owner_List(string name, string sec_name, string ph_num)
        {
            Name = name;
            Second_Name = sec_name;
            Phone_Number = ph_num;
        }

        public override string ToString()
        {
            return $"ID владельца: {ID_Owner}. Иья: {Name} Фамилия: {Second_Name} Номер телефона: {Phone_Number}";
        }
    }
}
