using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit_Library
{
    //virtual is for base classes
    //override is for child classes

    public class Personnel
    {
        public virtual void NumberOfPersonnel(int peoplePerSection)
        {
            Console.WriteLine($"There are currently {peoplePerSection} personnel assigned to this unit.\n");
            
        }
        
    }
}
