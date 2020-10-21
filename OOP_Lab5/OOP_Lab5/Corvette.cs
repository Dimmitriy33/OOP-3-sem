using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab5
{
    public class Corvette : TransportEl
    {
        public int CorvetteNumber;
        public string CorvetteName;
        public int SailorsNumber;

        public int CorvetteNUMBER
        {
            get { return CorvetteNumber; }
            set { CorvetteNumber = value; }
        }

        public int SailorsNUMBER
        {
            get { return SailorsNumber; }
            set { SailorsNumber = value; }
        }

        public string NAME
        {
            get { return CorvetteName; }
            set { CorvetteName = value; }
        }



        public Corvette()
        {
            this.CorvetteName = "";
            this.CorvetteNumber = 0;
            this.SailorsNumber = 0;
            base.CORVETTESCount++;
        }

        public Corvette(string CorvetteName, int SailorsNumber)
        {
            this.CorvetteName = CorvetteName;
            this.CorvetteNumber = CORVETTESCount;
            this.SailorsNumber = SailorsNumber;
            base.CORVETTESCount++;
        }

        public override string ToString()
        {
            return $"Type: Corvette\nCorvetteCount: {CORVETTESCount}";
        }
    }
}
