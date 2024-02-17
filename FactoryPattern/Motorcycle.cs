using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
     class Motorcycle
    {
        public string Name { get; set; }

        public bool HasTwoWheels {  get; set; }
        public void Drive()
        {
            Console.WriteLine("Can't talk on the motorcycle!!!");
        }
    }
}
