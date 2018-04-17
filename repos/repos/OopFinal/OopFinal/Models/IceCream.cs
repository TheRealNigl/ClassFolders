using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinal.Models
{
    abstract class IceCream : IProduct
    {
        public string name;
        public string price;

        List<Scoop> scoops = new List<Scoop>();
        List<Topping> topping = new List<Topping>();
        
        Scoop scoop = new Scoop(0);
        Cherry cherry = new Cherry();
        WhippedCream cream = new WhippedCream();

        public virtual string About()
        {
            return "You have ordered a ";
        }

        public void AddScoop()
        {
            scoops.Add(scoop);
        }

        public void AddTopping()
        {
            topping.Add(cherry);
            topping.Add(cream);
        }

        public string GetPrice()
        {
            return price;
        }

        public string GetScoopPrice()
        {
            string scoopPrice = scoop.About();
            price += scoopPrice;
            return scoopPrice;
        }

        private string GetScoopString()
        {
            string scoopString = scoop.About();
            name = scoopString;
            return scoopString;
        }

        private void GetToppingPrice()
        {
            string toppingPrice = cream.Price();
            string toppingPrice1 = cherry.Price();
            price += toppingPrice;
            price += toppingPrice1;
        }

        private string GetToppingString()
        {
            return " with a cherry and whipped cream";
        }

        public IceCream()
        {
            price = "$0.50";
            name = scoops.ToString();
        }
        
        public string Name()
        {
            return this.name;
        }
        
        public string Price()
        {
            return this.price;
        }
    }
}
