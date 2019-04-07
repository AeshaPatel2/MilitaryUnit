using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit_Library.ParachuteDataFolder
{
    public class PersonnelParachutes : Parachutes
    {
        public override void TotalNumberOfParachutes(int quantity)
        {
            Console.WriteLine($"Total Personnel parachutes: {quantity}\n");
        }

        public void PeopleParachutes(int quantity, string type)
        {
            Console.WriteLine($"{quantity} {type}");
        }

        

    }
}
