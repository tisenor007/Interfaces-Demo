using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is an Interfaces Demo");
            Console.WriteLine();

            Item item = new Item();
            Console.WriteLine();
            Knight knight = new Knight();
            Console.WriteLine();
            Archer archer = new Archer();
            Console.WriteLine();

            item.Collect();
            Console.WriteLine();
            knight.TakeDamage();
            Console.WriteLine();
            archer.TakeDamage();
            Console.WriteLine();
            //knight.Shoot();
            archer.Shoot();
            Console.ReadKey(true);
        }
    }
}
