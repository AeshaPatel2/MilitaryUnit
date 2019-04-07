using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit_Library.ParachuteDataFolder
{
    public class Cargo : Parachutes
    {
        public override void TotalNumberOfParachutes(int quantity)
        {
            Console.WriteLine($"Total Cargo parachutes: {quantity}");
        }

        public void HeavyRigParachutes(int quantity, string type)
        {
            Console.WriteLine($"{quantity} {type}");
        }


    }
}
