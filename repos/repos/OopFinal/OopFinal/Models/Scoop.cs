using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinal.Models
{
    class Scoop
    {
        enum Flavor
        {
            Chocolate,
            Vanilla,
            Strawberry,
            MiniChocolateChip
        };

        public string Price;

        public string About()
        {
            return " ";
        }

        /*
        public Scoop()
        {
            Flavor = 0;
            Price = "$0.50";
        }
        */
        
        public Scoop(int number)
        {
            number = (int)Flavor.Chocolate;
            Price = "$0.50";
        }
        
    }
}
