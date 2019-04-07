using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit_Library.PersonnelFolder
{
   public  class Managment : Personnel
    {
        public override void NumberOfPersonnel(int peoplePerSection)
        {
            Console.WriteLine($"Management (supply and NCOs): {peoplePerSection}\n");

        }
    }
}
