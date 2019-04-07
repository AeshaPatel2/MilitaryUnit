using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit_Library.PersonnelFolder
{
    public class LowerEnlisted : Personnel
    {
        public override void NumberOfPersonnel(int peoplePerSection)
        {
            Console.WriteLine($"Lower-Enlisted (juniors): {peoplePerSection}\n");

        }
    }
}
