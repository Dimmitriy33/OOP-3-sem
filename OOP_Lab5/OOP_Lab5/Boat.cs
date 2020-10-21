using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab5
{
    public class Boat : TransportEl
    {
        public int BoatNumber;
        public string BoatName;
        public int SailorsNumber;

        public int BoatNUMBER
        {
            get { return BoatNumber; }
            set { BoatNumber = value; }
        }

        public int SailorsNUMBER
        {
            get { return SailorsNumber; }
            set { SailorsNumber = value; }
        }

        public string NAME
        {
            get { return BoatName; }
            set { BoatName = value; }
        }



        public Boat()
        {
            this.BoatName = "";
            this.BoatNumber = 0;
            this.SailorsNumber = 0;
            base.BOATSCount++;
        }

        public Boat(string BoatName, int SailorsNumber)
        {
            this.BoatName = BoatName;
            this.BoatNumber = BOATSCount;
            this.SailorsNumber = SailorsNumber;
            base.BOATSCount++;
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            Boat boat = new Boat();
            boat = (Boat)obj;
            return (this.BoatName == boat.BoatName && this.SailorsNumber == boat.SailorsNumber);
        }

        public new Type GetType()
        {
            return this.GetType();
        }

        public string WriteType()
        {
            return "Boat obj";
        }

        public override string ToString()
        {
            return $"Type: Boat\nBoatCount: {BOATSCount}";
        }


    }
}
