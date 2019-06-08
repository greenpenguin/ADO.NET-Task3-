using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class House
    {
        public int ID_House { get; set; }
        public string Address { get; set; }

        public House()
        { }

        public House(string adrs)
        {
            Address = adrs;
        }

        public override string ToString()
        {
            return $"ID дома: {ID_House}. Адрес: {Address}";
        }
    }
}
