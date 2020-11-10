using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab6
{
    public class Ship : TransportEl
    {
        enum shedule : long //yyyymmddhhmm(год месяц день час минута)
        {
            first = 202010210620,
            second = 202010211315,
            third = 202010211800,
            fourth = 202010212220
        }

        public int ShipsNumber;
        public string ShipName;
        public int SailorsNumber;
        public Captain captain;

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

        public int CaptainAge
        {
            get { return this.captain.age; }
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


        public override string ToString()
        {
            return  $"Type: Ship\nShipsCount: {SHIPSCount}\nShedule(yyyymmddhhmm):\n   1. {(long)shedule.first}\n   2. {(long)shedule.second}\n   3. {(long)shedule.third}\n   4. {(long)shedule.fourth}\n";
        }

    }
}
