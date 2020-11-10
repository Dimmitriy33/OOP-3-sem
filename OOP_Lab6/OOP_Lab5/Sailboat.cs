using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab6
{
    public class Sailboat : TransportEl // парусник
    {
        public static int totalDisplacement = 0;

        public int SailboatNumber;
        public string SailboatName;
        public int SailorsNumber;
        public int displacement;
        public Captain captain;

        public int SailboatNUMBER
        {
            get { return SailboatNumber; }
            set { SailboatNumber = value; }
        }

        public int SailorsNUMBER
        {
            get { return SailorsNumber; }
            set { SailorsNumber = value; }
        }

        public string NAME
        {
            get { return SailboatName; }
            set { SailboatName = value; }
        }

        public int DISPLACEMENT
        {
            get { return displacement; }
            set { displacement = value; }
        }

        public int CaptainAge
        {
            get { return this.captain.age; }
        }

        public Sailboat()
        {
            this.SailboatName = "";
            this.SailboatNumber = 0;
            this.SailorsNumber = 0;
            this.displacement = 0;
            this.captain = new Captain();
            base.SAILBOATSCount++;
        }

        public Sailboat(string SailboatName, int SailorsNumber)
        {
            this.SailboatName = SailboatName;
            this.SailboatNumber = SAILBOATSCount;
            this.SailorsNumber = SailorsNumber;
            this.captain = new Captain();
            base.SAILBOATSCount++;
        }

        public Sailboat(string SailboatName, int SailorsNumber, Captain captain)
        {
            this.SailboatName = SailboatName;
            this.SailboatNumber = SAILBOATSCount;
            this.SailorsNumber = SailorsNumber;
            this.captain = captain;
            base.SAILBOATSCount++;
        }

        public Sailboat(string SailboatName, int SailorsNumber, int displacement)
        {
            this.SailboatName = SailboatName;
            this.SailboatNumber = SAILBOATSCount;
            this.SailorsNumber = SailorsNumber;
            this.displacement = displacement;
            totalDisplacement += this.displacement;
            this.captain = new Captain();
            base.SAILBOATSCount++;
        }

        public override string ToString()
        {
            return $"Type: Sailboat\nSailboatsCount: {SAILBOATSCount}";
        }
    }
}
