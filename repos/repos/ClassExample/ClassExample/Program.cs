using System;
using System.Collections.Generic;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            List<Player> ListOfPlayer = new List<Player>();
            ListOfPlayer.Add(player);
            player.FirstName = "Alex";
            Console.WriteLine(ListOfPlayer[0].FirstName);
            Console.WriteLine(ListOfPlayer.Find(a => a.FirstName == "Alex").FirstName);
            Console.ReadLine();
        }
    }
}
