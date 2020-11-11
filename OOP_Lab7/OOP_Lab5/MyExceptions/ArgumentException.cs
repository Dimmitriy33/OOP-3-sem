using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace OOP_Lab7.MyExceptions
{
    class ArgumentException : Exception
    {
        public ArgumentException() : base("Argumnet exception") { }
    }
}
