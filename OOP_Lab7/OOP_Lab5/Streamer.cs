using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace OOP_Lab6
{
    public class Streamer : TransportEl
    {
        public static int totalSeatsNumber;

        public int StreamerNumber;
        public string StreamerName;
        public int SailorsNumber;
        public int SeatsNumber;
        public Captain captain;

        public int StreamerNUMBER
        {
            get { return StreamerNumber; }
            set { StreamerNumber = value; }
        }

        public int SailorsNUMBER
        {
            get { return SailorsNumber; }
            set { SailorsNumber = value; }
        }

        public string NAME
        {
            get { return StreamerName; }
            set { StreamerName = value; }
        }

        public int SeatsNUMBER
        {
            get { return SeatsNumber; }
            set { SeatsNumber = value; }
        }

        public int CaptainAge
        {
            get { return this.captain.age; }
        }


        public Streamer()
        {
            this.StreamerName = "";
            this.StreamerNumber = 0;
            this.SailorsNumber = 0;
            base.STREAMERSCount++;
            this.SeatsNumber = 0;
            this.captain = new Captain();
        }

        public Streamer(string StreamerName, int SailorsNumber, int SeatsNumber)
        {
            this.StreamerName = StreamerName;
            this.StreamerNumber = STREAMERSCount;
            this.SailorsNumber = SailorsNumber;
            this.SeatsNumber = SeatsNumber;
            totalSeatsNumber += SeatsNumber;
            this.captain = new Captain();
            base.STREAMERSCount++;
        }

        public Streamer(string StreamerName, int SailorsNumber, int SeatsNumber, Captain captain)
        {
            this.StreamerName = StreamerName;
            this.StreamerNumber = STREAMERSCount;
            this.SailorsNumber = SailorsNumber;
            this.SeatsNumber = SeatsNumber;
            totalSeatsNumber += SeatsNumber;
            this.captain = captain;
            base.STREAMERSCount++;
        }

        public Streamer(Captain captain)
        {
            this.StreamerName = "";
            this.StreamerNumber = 0;
            this.SailorsNumber = 0;
            base.STREAMERSCount++;
            this.SeatsNumber = 0;
            this.captain = captain;
        }

        public override string ToString()
        {
            return $"Type: Streamer\nStreamersCount: {STREAMERSCount}";
        }
    }
}
