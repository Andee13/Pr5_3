using System;

namespace ConsoleApp1
{
    public class Ship
    {
        private String name;
        private String purpose;
        private int power;
        private int waterSupply;
        private String typeOfFuel;

        public Ship(string name, string purpose, int power, int waterSupply, string typeOfFuel)
        {
            this.name = name;
            this.purpose = purpose;
            this.power = power;
            this.waterSupply = waterSupply;
            this.typeOfFuel = typeOfFuel;
        }

        public override string ToString()
        {
            return $"{nameof(name)}: {name}, {nameof(purpose)}: {purpose}, {nameof(power)}: {power}, {nameof(waterSupply)}: {waterSupply}, {nameof(typeOfFuel)}: {typeOfFuel}";
        }
    }
}