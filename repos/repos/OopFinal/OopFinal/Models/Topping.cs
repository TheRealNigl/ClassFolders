using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinal.Models
{
    abstract class Topping : IProduct
    {
        public string name;
        public string price;

        public string About()
        {
            return $"{Name()} + {Price()}";
        }

        public Topping()
        {
        }
        
        public string Name()
        {
            return name;
        }

        public string Price()
        {
            return price;
        }
        
    }
}
