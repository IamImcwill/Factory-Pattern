using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
     class Car
    {
        public string Color { get; set; }
        public bool IsDriveable { get; set; }
        public void Drive() 
        {
            Console.WriteLine("Can't text I'm driving!!!");
        }
    }
}
