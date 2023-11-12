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
        private Wall _wallprototype;
        private RoomWithTrap _roomWithTrapprototype;
        private Maze _mazeprototype;
        private DoorWithTrap _doorWithTrapprototype;

        public MazeWithBombPrototype(RoomWithTrap roomWithTrap, DoorWithTrap doorWithTrap, Wall wall, Maze mazeprototype)
        {
            _wallprototype = wall;
            _roomWithTrapprototype = roomWithTrap;
            _mazeprototype = mazeprototype;
            _doorWithTrapprototype = doorWithTrap;
        }

        public override Wall CreateWall()
        {
            return _wallprototype.Clone();
        }

        public override RoomWithTrap CreateRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Ожидается положительное число");
            }
            return _roomWithTrapprototype.Clone();
        }

        public override Maze CreateMaze()
        {
            return _mazeprototype.Clone();
        }

        public override DoorWithTrap CreateDoor(Room room1, Room room2)
        {
            if (room1 == null)
                throw new ArgumentNullException(nameof(room1));
            if (room2 == null)
                throw new ArgumentNullException(nameof(room2));
            return (DoorWithTrap)_doorWithTrapprototype.Clone();
        }
    }
}
