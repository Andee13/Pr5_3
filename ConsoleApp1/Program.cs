using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship("AndrewShip", "military", 300, 200, "oil");
            Carrier carrier = new Carrier("AndrewShip", "military", 300, 200, "oil","simple jets", 30);
            RocketShip rocketShip = new RocketShip("AndrewShip", "military", 300, 200, "oil",40,"military");
            Console.WriteLine(ship.ToString());
            Console.WriteLine(carrier.ToString());
            Console.WriteLine(rocketShip.ToString());
        }
    }
}