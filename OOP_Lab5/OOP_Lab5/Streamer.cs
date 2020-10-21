using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace OOP_Lab5
{
    public class Streamer : TransportEl
    {
        public int StreamerNumber;
        public string StreamerName;
        public int SailorsNumber;

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



        public Streamer()
        {
            this.StreamerName = "";
            this.StreamerNumber = 0;
            this.SailorsNumber = 0;
            base.STREAMERSCount++;
        }

        public Streamer(string StreamerName, int SailorsNumber)
        {
            this.StreamerName = "";
            this.StreamerNumber = STREAMERSCount;
            this.SailorsNumber = SailorsNumber;
            base.STREAMERSCount++;
        }

        public override string ToString()
        {
            return $"Type: Streamer\nStreamersCount: {STREAMERSCount}";
        }
    }
}
