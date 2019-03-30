using System;

namespace ConsoleApp1
{
    public class Carrier : Ship
    {
        private String typeOfJets;
        private int jetsNumber;

        public Carrier(string name, string purpose, int power, int waterSupply, string typeOfFuel, string typeOfJets, int jetsNumber) : base(name, purpose, power, waterSupply, typeOfFuel)
        {
            this.typeOfJets = typeOfJets;
            this.jetsNumber = jetsNumber;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(typeOfJets)}: {typeOfJets}, {nameof(jetsNumber)}: {jetsNumber}";
        }
    }
}