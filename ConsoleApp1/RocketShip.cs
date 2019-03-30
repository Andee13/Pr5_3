using System;

namespace ConsoleApp1
{
    public class RocketShip: Ship
    {
        private int NumberOfRockets;
        private String TypeOfRockets;

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(NumberOfRockets)}: {NumberOfRockets}, {nameof(TypeOfRockets)}: {TypeOfRockets}";
        }

        public RocketShip(string name, string purpose, int power, int waterSupply, string typeOfFuel, int numberOfRockets, string typeOfRockets) : base(name, purpose, power, waterSupply, typeOfFuel)
        {
            NumberOfRockets = numberOfRockets;
            TypeOfRockets = typeOfRockets;
        }
        
    }
}