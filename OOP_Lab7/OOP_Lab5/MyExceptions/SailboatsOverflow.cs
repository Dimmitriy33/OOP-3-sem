using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OOP_Lab7.MyExceptions
{
    class SailboatsOverflow : Exception
    {
        public SailboatsOverflow(object obj) : base("Count of sailboats ovetflow")
        {
            Source = obj.GetType().ToString();
        }
    }
}
