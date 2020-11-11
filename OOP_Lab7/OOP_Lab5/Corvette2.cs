using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab6
{
    partial class Corvette : TransportEl
    {
        public Corvette()
        {
            this.CorvetteName = "";
            this.CorvetteNumber = 0;
            this.SailorsNumber = 0;
            this.captain = new Captain();
            base.CORVETTESCount++;
        }

        public Corvette(string CorvetteName, int SailorsNumber)
        {
            this.CorvetteName = CorvetteName;
            this.CorvetteNumber = CORVETTESCount;
            this.SailorsNumber = SailorsNumber;
            this.captain = new Captain();
            base.CORVETTESCount++;
        }

        public Corvette(string CorvetteName, int SailorsNumber, Captain captain)
        {
            this.CorvetteName = CorvetteName;
            this.CorvetteNumber = CORVETTESCount;
            this.SailorsNumber = SailorsNumber;
            this.captain = captain;
            base.CORVETTESCount++;
        }

        public override string ToString()
        {
            return $"Type: Corvette\nCorvetteCount: {CORVETTESCount}";
        }
    }
}
