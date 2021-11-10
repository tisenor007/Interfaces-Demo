using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Item : IPickupable
    {
        public Item()
        {
            Console.WriteLine("Item Constructed");
        }
        
        public void Collect()
        {
            Console.WriteLine("Item Collected");
        }

        public void Drop()
        {
            Console.WriteLine("Item dropped");
        }
    }
}
