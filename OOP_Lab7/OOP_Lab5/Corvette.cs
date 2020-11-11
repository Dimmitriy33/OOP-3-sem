using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab6
{
    public partial class Corvette : TransportEl
    {
        public int CorvetteNumber;
        public string CorvetteName;
        public int SailorsNumber;
        public Captain captain;

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

        public int CaptainAge
        {
            get { return this.captain.age; }
        }

    }
}
