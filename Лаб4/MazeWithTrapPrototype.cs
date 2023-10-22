using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб4
{
    public class MazeWithTrapPrototype : MazeFactoryPrototype
    {

        public override Room CreateRoom(int Number)
        {
            if (Number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Number), Number, "Ожидается положительное число");
            }
            return new RoomWithTrap(Number);
        }

        public override Door CreateDoor(Room room1, Room room2)
        {
            ArgumentNullException.ThrowIfNull(room1);
            ArgumentNullException.ThrowIfNull(room2);

            return new DoorWithTrap(room1, room2);
        }

        public ICloneablePrototype Clone() => (ICloneablePrototype)MemberwiseClone();
    }
}
