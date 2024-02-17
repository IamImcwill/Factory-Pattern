using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class VehicleFactory
    {
        public Car CreateVehicle(string userInput) 
        {
            switch (userInput.ToLower())
            {
                case "car":
                    return new Car();
                case "motorcycle":
                    return new Motorcycle();
                default:
                    break;
            }
        }
    }
}
