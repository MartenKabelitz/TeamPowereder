using System;
using System.Collections.Generic;
using System.Text;

namespace Teampow
{
    class BaseClass
    {
        public string FirstName { get; set; }       
        public string Adress { get; set; }

        public int Income { get; set; }

        public void Ausgabe()
        {
            Console.WriteLine("hi");
        }
    }
}
