using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Door : IMapSite
    {
        private readonly Room room1;
        private readonly Room room2;
        public readonly bool _isOpen;

        public Door(Room room1, Room room2)
        {
            ArgumentNullException.ThrowIfNull(room1);
            ArgumentNullException.ThrowIfNull(room2);

            this.room1 = room1;
            this.room2 = room2;
            _isOpen = true;
        }

        public void Enter()
        {
            if (_isOpen)
            {
                Console.WriteLine("Мы вошли в дверь");
            }
            else
            {
                Console.WriteLine("Дверь закрыта");
            }
        }
        public Room OtherSideFrom(Room room)
        {
            if (room.roomNumber == room1.roomNumber)
            {
                return room2;
            }
            else if (room.roomNumber == room2.roomNumber)
            {
                return room1;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
