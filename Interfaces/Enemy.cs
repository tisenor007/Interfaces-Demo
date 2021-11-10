using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Enemy : IDamageable
    {
        //classes are inherited,
        //interfaces are implemented
        public Enemy()
        {
            Console.WriteLine("Enemy Constructed");
        }

        public void TakeDamage()
        {
            Console.WriteLine("Enemy took damage");
        }
    }
}
