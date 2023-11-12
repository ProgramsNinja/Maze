using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Лаб1;

namespace Лаб4
{
    public class MazeFactoryPrototype : MazeFactory
    {
        private Room _roomprototype;
        private Door _doorprototype;
        private Wall _wallprototype;
        private Maze _mazeprototype;

        public MazeFactoryPrototype(Room roomprototype, Door doorprototype, Wall wallprototype, Maze mazeprototype)
        {
            _roomprototype = roomprototype;
            _doorprototype = doorprototype;
            _wallprototype = wallprototype;
            _mazeprototype = mazeprototype;
        }

        public override Maze CreateMaze() => _mazeprototype;
        public override Room CreateRoom(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number");
            }
            return _roomprototype.Clone();
        }
        public override Wall CreateWall() => new();

        public override Door CreateDoor(Room room1, Room room2)
        {
            if (room1 == null)
                throw new ArgumentNullException();
            if (room2 == null)
                throw new ArgumentNullException();
            return _doorprototype.Clone();
        }
    }
}
