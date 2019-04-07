using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit_Library.TransportationFolder
{
    public class Vehicles : Transportation
    {
        public override void NumberOfTrans(int quantity)
        {
            Console.WriteLine($"Total number of ground transportation: {quantity}");
        }

        public void NumberOfVehicles(int quantity, string type)
        {
            Console.WriteLine($"{quantity} {type}");


        }
    }
}
