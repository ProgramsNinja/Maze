using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб3
{
    public class MazeWithTrapGame : MazeGame
    {
        public override Room CreateRoom(int number)
        {
            if (number < -0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Ожидается положительное число");
            }
            return new RoomWithBomb(number);
        }

        public override Door CreateDoor(Room room1, Room room2)
        {
            ArgumentNullException.ThrowIfNull(room1);
            ArgumentNullException.ThrowIfNull(room2);

            return new DoorWithTrap(room1, room2);
        }
    }
}
