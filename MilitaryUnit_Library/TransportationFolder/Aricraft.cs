using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit_Library.TransportationFolder
{
    public class Aircraft : Transportation
    {
        public override void NumberOfTrans(int quantity)
        {
            Console.WriteLine($"Total number of air Aircraft: {quantity}");
        }

        public void NumberOfAirCrafts(int quantity, string type)
        {
            Console.WriteLine($"{quantity} {type}");
        }
    }
}
