using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab5
{
    public class Ship : TransportEl
    {
        public int ShipsNumber;
        public string ShipName;
        public int SailorsNumber;
        Captain captain;

        public int ShipsNUMBER
        {
            get { return ShipsNumber; }
            set { ShipsNumber = value; }
        }

        public int SailorsNUMBER
        {
            get { return SailorsNumber; }
            set { SailorsNumber = value; }
        }

        public string NAME
        {
            get { return ShipName; }
            set { ShipName = value; }
        }

        public Ship()
        {
            this.ShipName = "";
            this.ShipsNumber = SHIPSCount;
            this.SailorsNumber = 0;
            base.SHIPSCount++;
            this.captain = new Captain();
        }

        public Ship(string ShipName, int SailorsNumber)
        {
            this.ShipName = ShipName;
            this.ShipsNumber = SHIPSCount;
            this.SailorsNumber = SailorsNumber;
            this.captain = new Captain();
            base.SHIPSCount++;
        }

        public Ship(string ShipName, int SailorsNumber, Captain captain)
        {
            this.ShipName = ShipName;
            this.ShipsNumber = SHIPSCount;
            this.SailorsNumber = SailorsNumber;
            this.captain = captain;
            base.SHIPSCount++;
        }

        public class Captain
        {
            string name;
            int age;
            int YearsExperience;

            public Captain()
            {
                this.name = "";
                this.age = 0;
                this.YearsExperience = 0;
            }

            public Captain(string Name, int Age, int yearsExperience )
            {
                this.name = Name;
                this.age = Age;
                this.YearsExperience = yearsExperience;
            }
        }

        public override string ToString()
        {
            return $"Type: Ship\nCorvetteCount: {SHIPSCount}";
        }

    }
}
