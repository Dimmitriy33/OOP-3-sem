using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace OOP_Lab6
{
    abstract class Control : Port
    {
        public static int CountOfLess35Captain(Port port)
        {
            int sum = 0;
            for (int i = 0; i < port.elems.Count; i++)
            {
                // лучше не придумал
                if(port.elems[i] is Boat)
                {
                    Boat boat = new Boat();
                    boat = (Boat)port.elems[i];
                    if (boat.CaptainAge < 35)
                        sum += 1;
                }

                if (port.elems[i] is Corvette)
                {
                    Corvette corvette = new Corvette();
                    corvette = (Corvette)port.elems[i];
                    if (corvette.CaptainAge < 35)
                        sum += 1;
                }

                if (port.elems[i] is Sailboat)
                {
                    Sailboat sailboat = new Sailboat();
                    sailboat = (Sailboat)port.elems[i];
                    if (sailboat.CaptainAge < 35)
                        sum += 1;
                }

                if (port.elems[i] is Ship)
                {
                    Ship ship = new Ship();
                    ship = (Ship)port.elems[i];
                    if (ship.CaptainAge < 35)
                        sum += 1;
                }

                if (port.elems[i] is Streamer)
                {
                    Streamer streamer = new Streamer();
                    streamer = (Streamer)port.elems[i];
                    if (streamer.CaptainAge < 35)
                        sum += 1;
                }
            }
            return sum;
        }
        public static int AverageSeats() {return Streamer.totalSeatsNumber / TransportEl.StreamersCount; }

        public static int AverageDisplacementOnSailboats() { return Sailboat.totalDisplacement / TransportEl.SailboatsCount; }
    }
}
