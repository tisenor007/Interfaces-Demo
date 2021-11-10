using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Archer : Enemy, IShootable
    {
        public Archer()
        {
            Console.WriteLine("Archer Constructed");
        }

        public void Shoot()
        {
            Console.WriteLine("Archer Shot");
        }
    }
}
