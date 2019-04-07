using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit_Library.PersonnelFolder
{
    public class Corporate : Personnel
    {
        public override void NumberOfPersonnel(int peoplePerSection)
        {
            Console.WriteLine($"Higher Enlisted (Captain, Chiefs, and 1sgt): {peoplePerSection}\n");
         

        }
    }
}
