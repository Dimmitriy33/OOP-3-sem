using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab14
{
    [Serializable]
    [DataContract]
    public class Ship
    {
        private int size;
        private int sailorsNumber;
        private string name;

        [NonSerialized]
        private const string rubbish = "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";

        [DataMember]
        public string Name 
        {
            set => name = value;
            get => name;
        } 

        [DataMember]
        public int Size
        {
            get => size;
            set => size = value;
        }

        [DataMember]
        public int SailorsNumber
        {
            get => sailorsNumber;
            set => sailorsNumber = value;
        }

        public Ship()
        {
            Size = 0;
            SailorsNumber = 0;
            Name = "None";
        }

        public Ship(int s, int snum, string n)
        {
            Size = s;
            SailorsNumber = snum;
            Name = n;
        }

        public void Info() => Console.WriteLine($"Ship Info: Name: {Name}, Sailors Number: {SailorsNumber}, Size: {Size}");

        public void SailorsPerMeter() => Console.WriteLine($"Sailorsper meter: {SailorsNumber / Size}");

    }
}
