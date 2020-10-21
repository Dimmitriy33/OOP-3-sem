using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab5
{
    public class Sailboat : TransportEl // парусник
    {
        public int SailboatNumber;
        public string SailboatName;
        public int SailorsNumber;

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



        public Sailboat()
        {
            this.SailboatName = "";
            this.SailboatNumber = 0;
            this.SailorsNumber = 0;
            base.SAILBOATSCount++;
        }

        public Sailboat(string SailboatName, int SailorsNumber)
        {
            this.SailboatName = SailboatName;
            this.SailboatNumber = SAILBOATSCount;
            this.SailorsNumber = SailorsNumber;
            base.SAILBOATSCount++;
        }

        public override string ToString()
        {
            return $"Type: Sailboat\nCorvetteCount: {SAILBOATSCount}";
        }
    }
}
