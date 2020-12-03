using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace OOP_Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(70, 23, "NeBeda");

            // 1

            //Binary
            BinaryFormatter binary = new BinaryFormatter();
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\BinaryFormatter.txt", FileMode.OpenOrCreate))
            {
                binary.Serialize(stream, ship);
                Console.WriteLine("Binary serialization of ship is successful, check BinaryFormatter.txt");
            }
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\BinaryFormatter.txt", FileMode.Open))
            {
                Ship ship2 = (Ship)binary.Deserialize(stream);
                Console.WriteLine("Binary deserialization of ship is successful");
                ship2.Info();
                Console.WriteLine();
            }

            //Soap
            SoapFormatter soap = new SoapFormatter();
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\SoapFormatter.txt", FileMode.OpenOrCreate))
            {
                soap.Serialize(stream, ship);
                Console.WriteLine("Soap serialization of ship is successful, check SoapFormatter.txt");
            }
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\SoapFormatter.txt", FileMode.Open))
            {
                Ship ship2 = (Ship)soap.Deserialize(stream);
                Console.WriteLine("Soap deserialization of ship is successful");
                ship2.Info();
                Console.WriteLine();
            }

            //Xml
            XmlSerializer xml = new XmlSerializer(typeof(Ship));
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\XmlSerializer.txt", FileMode.OpenOrCreate))
            {
                xml.Serialize(stream, ship);
                Console.WriteLine("Xml serialization of ship is successful, check XmlSerializer.txt");
            }
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\XmlSerializer.txt", FileMode.Open))
            {
                Ship ship2 = (Ship)xml.Deserialize(stream);
                Console.WriteLine("Xml deserialization of ship is successful");
                ship2.Info();
                Console.WriteLine();
            }

            //Json
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Ship));
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\JsonSerializer.txt", FileMode.OpenOrCreate))
            {
                json.WriteObject(stream, ship);
                Console.WriteLine("Json serialization of ship is successful, check JsonSerializer.txt");
            }
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\JsonSerializer.txt", FileMode.Open))
            {
                Ship ship2 = (Ship)json.ReadObject(stream);
                Console.WriteLine("Json deserialization of ship is successful");
                ship2.Info();
                Console.WriteLine();
            }

            //2
            Ship[] ships = new Ship[] {ship, new Ship(70, 23, "OBed"), new Ship(70, 23, "Bedlam") };
            XmlSerializer XmlArr = new XmlSerializer(typeof(Ship[]));
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\MassXmlSerializer.txt", FileMode.OpenOrCreate))
            {
                XmlArr.Serialize(stream, ships);
                Console.WriteLine("Xml serialization of XmlArr is successful, check MassXmlSerializer.txt");
            }
            using (FileStream stream = new FileStream(@"D:\учеба\ООП\lab14\MassXmlSerializer.txt", FileMode.Open))
            {
                Ship[] ship2 = (Ship[])XmlArr.Deserialize(stream);
                Console.WriteLine("Xml deserialization of XmlArr is successful");
                for (int i = 0; i < 3; i++)
                {
                    ship2[i].Info();
                }
                Console.WriteLine();
            }

            //3
            XPathDocument doc = new XPathDocument(@"D:\учеба\ООП\lab14\MassXmlSerializer.txt");
            XPathNavigator navigator = doc.CreateNavigator();
            XPathNodeIterator iter = navigator.Select("/ArrayOfShip/Ship");
            Console.WriteLine("Ships count: " + navigator.Evaluate("count(/ArrayOfShip/Ship)"));
            while (iter.MoveNext())
            {
                Console.WriteLine($"Ship: {iter.Current.Value}");
            }
            Console.WriteLine();

            //4
            XDocument xdoc = new XDocument(new XElement("Seas",
                new XElement("sea", new XAttribute("Name", "Black sea"),
                    new XElement("continent", "Eurasia"),
                    new XElement("square", "1000")),
                new XElement("sea", new XAttribute("Name", "Mediterranean"),
                    new XElement("continent", "Europe"),
                    new XElement("square", "2000"))));
            xdoc.Save(@"D:\учеба\ООП\lab14\LinqXml.txt");

            XDocument xdoc2 = XDocument.Load(@"D:\учеба\ООП\lab14\LinqXml.txt");
            var linqXml = from x in xdoc2.Descendants("sea")
                          where x.Element("square").Value == "2000"
                          select new
                          {
                              Name = x.Attribute("Name").Value,
                              Square = x.Element("square").Value
                          };
            foreach (var x in linqXml)
            {
                Console.WriteLine($"Sea: {x.Name}, {x.Square}");
            }
        }
    }
}
