using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopFinal.Models;

namespace OopFinal
{
    class Program
    {
        static void Main(string[] args)
        {

            IceCreamSundae sundae = new IceCreamSundae();
            string price = sundae.GetScoopPrice();
            Console.WriteLine(price);
            Console.WriteLine(sundae.Price());
            Console.WriteLine(sundae.About() + "sundae.");
            

            IceCreamSugarCone sugarCone = new IceCreamSugarCone();
            Console.WriteLine(sugarCone.Price());
            Console.WriteLine(sugarCone.About() + "sugar cone.");
            

            IceCreamWaffle waffle = new IceCreamWaffle();
            waffle.AddTopping();
            Console.WriteLine(waffle.Price());
            Console.WriteLine(waffle.About() + "waffle.");

            Console.WriteLine();
            
            
            Console.ReadKey();

        }
    }
}
