using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб2
{
    internal class MazeWithTrapBuilder:MazeBuilder
    {
        protected Maze maze = new();

        public virtual void BuildRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Ожидается положительное число");
            }

            RoomWithBomb room = new(number);
            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.East, new Wall());
            room.SetSide(Direction.South, new Wall());
            room.SetSide(Direction.West, new Wall());

            maze.AddRoom(room);

        }

        public virtual void BuildDoor(int roomNum1, int roomNum2)
        {
            if (roomNum1 <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNum1), roomNum1, "Ожидается положительное число");
            }

            if (roomNum2 <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNum2), roomNum2, "Ожидается положительное число");
            }

            Room room1 = maze.RoomNo(roomNum1);
            ArgumentNullException.ThrowIfNull(room1);

            Room room2 = maze.RoomNo(roomNum2);
            ArgumentNullException.ThrowIfNull(room2);

            Door door = new(room1, room2);
            var tuple = CreateADoor(room1, room2);
            room1.SetSide(tuple.Item1, door);
            room2.SetSide(tuple.Item2, door);
        }

        public Maze GetMaze()
        {
            return maze;
        }
    }
}
