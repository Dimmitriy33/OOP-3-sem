using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;

namespace OOP_Lab6
{
    public class TransportEl
    {
        public static string PortName = "";
        public static int StreamersCount = 0;
        public static int ShipsCount = 0;
        public static int BoatsCount = 0;
        public static int SailboatsCount = 0;
        public static int CorvettesCount = 0;

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
            
        }

        public TransportEl(string PortNameNew, int ShipsCountNew, int StreamersCountNew, int SailBoatsCountNew, int CorvettesCountNew)
        {
            PortName = PortNameNew;
            CorvettesCount = CorvettesCountNew;
            SailboatsCount = SailBoatsCountNew;
            ShipsCount = ShipsCountNew;
            StreamersCount = StreamersCountNew;
        }

        public TransportEl(string PortNameNew)
        {
            PortName = PortNameNew;
            CorvettesCount = CORVETTESCount;
            SailboatsCount = SAILBOATSCount;
            ShipsCount = SHIPSCount;
            StreamersCount = STREAMERSCount;
        }

        public override string ToString()
        {
            return $"Type: TransportEl\nPortName: {PortName}\nCorvettesCount: {CORVETTESCount}\nSailboatsCount: {SAILBOATSCount}" +
                   $"\nShipsCount: {SHIPSCount}\nStreamersCount: {STREAMERSCount}\n";
        }
    }

    public class Captain
    {
        public string name;
        public int age;
        public int YearsExperience;

        public Captain()
        {
            this.name = "";
            /*this.age = 0;*/
            this.YearsExperience = 0;
        }

        public Captain(string Name, int Age, int yearsExperience)
        {
            this.name = Name;
            this.age = Age;
            this.YearsExperience = yearsExperience;
        }
    }
}
