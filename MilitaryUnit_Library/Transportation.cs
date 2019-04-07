using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit_Library
{
    public class Transportation
    {
        public virtual void NumberOfTrans(int quantity)
        {
            Console.WriteLine($"Your unit currently has a total number of {quantity} trans available for airborne ops.\n");
        }

    }


}
