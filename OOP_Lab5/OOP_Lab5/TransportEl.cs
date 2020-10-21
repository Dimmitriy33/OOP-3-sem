using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;

namespace OOP_Lab5
{
    public abstract class TransportEl
    {
        public string PortName;
        public int StreamersCount;
        public int ShipsCount;
        public int BoatsCount;
        public int SailboatsCount;
        public int CorvettesCount;

        public string PORTName
        {
            get { return PortName; }
            set { PortName = value; }
        }

        public int STREAMERSCount
        {
            get { return StreamersCount; }
            set { StreamersCount = value; }
        }

        public int SHIPSCount
        {
            get { return ShipsCount; }
            set { ShipsCount = value; }
        }

        public int SAILBOATSCount
        {
            get { return SailboatsCount; }
            set { SailboatsCount = value; }
        }

        public int CORVETTESCount
        {
            get { return CorvettesCount; }
            set { CorvettesCount = value; }
        }

        public int BOATSCount
        {
            get { return BoatsCount; }
            set { BoatsCount = value; }
        }

        public TransportEl()
        {
            this.PortName = "MyPort";
            this.CorvettesCount = 0;
            this.SailboatsCount = 0;
            this.ShipsCount = 0;
            this.StreamersCount = 0;
        }

        public TransportEl(string PortName, int ShipsCount, int StreamersCount, int SailBoatsCount, int CorvettesCount)
        {
            this.PortName = PortName;
            this.CorvettesCount = CorvettesCount;
            this.SailboatsCount = SailBoatsCount;
            this.ShipsCount = ShipsCount;
            this.StreamersCount = StreamersCount;
        }

        public TransportEl(string PortName)
        {
            this.PortName = PortName;
            this.CorvettesCount = CORVETTESCount;
            this.SailboatsCount = SAILBOATSCount;
            this.ShipsCount = SHIPSCount;
            this.StreamersCount = STREAMERSCount;
        }

        public override string ToString()
        {
            return $"Type: TransportEl\nPortName: {PortName}\nCorvettesCount: {CORVETTESCount}\nSailboatsCount: {SAILBOATSCount}" +
                   $"\nShipsCount: {SHIPSCount}\nStreamersCount: {STREAMERSCount}\n";
        }
    }
}
