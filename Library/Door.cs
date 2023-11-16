using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Door : IMapSite
    {
        private Room _room1 { get; set; }
        private Room _room2 { get; set; }
        public bool isOpen { get; private init; }

        public Door(Room room1, Room room2)
        {
            ArgumentNullException.ThrowIfNull(room1);
            ArgumentNullException.ThrowIfNull(room2);

            this._room1 = room1;
            this._room2 = room2;
            isOpen = true;
        }

        public Door()
        { }
        public void Initialize(Room r1, Room r2)
        {
            _room1 = r1;
            _room2 = r2;
        }
        public void Enter()
        {
            if (isOpen)
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
            if (room.roomNumber == _room1.roomNumber)
            {
                return _room2;
            }
            else if (room.roomNumber == _room2.roomNumber)
            {
                return _room1;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public virtual Door Clone()
        {
            return (Door)this.MemberwiseClone();
        }
    }
}
