using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit_Library
{
    public class Parachutes
    {
        public virtual void TotalNumberOfParachutes(int quantity)
        {
            Console.WriteLine($"Total number of parachutes: {quantity}");
        }
    }
}
