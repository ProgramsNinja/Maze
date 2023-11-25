using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DoorWithTrap : Door
    {
        public DoorWithTrap(Room room1, Room room2) : base(room1, room2) { }
        public DoorWithTrap() { }
        public  void Enter()
        {
            if (isOpen)
            {
                Console.WriteLine("Мы вошли в дверь");
            }
        }
        public override IMapSite Clone()
        {
            DoorWithTrap clonedDoor = (DoorWithTrap)base.Clone();
            return clonedDoor;
        }
    }
}
