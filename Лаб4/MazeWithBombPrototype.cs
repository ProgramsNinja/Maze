using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб4
{
    public class MazeWithBombPrototype : MazeFactoryPrototype
    {
        private WallWithBomb _wallprototype;
        private RoomWithBomb _roomprototype;
        private Maze _mazeprototype;
        private Door _doorprototype;

        public MazeWithBombPrototype(RoomWithBomb roomWithBomb, Door door, WallWithBomb wallWithBomb, Maze mazeprototype)
            : base(door, mazeprototype)
        {
            _wallprototype = wallWithBomb;
            _roomprototype = roomWithBomb;
            _mazeprototype = mazeprototype;
            _doorprototype = door;
        }

        public override WallWithBomb CreateWall()
        {
            return _wallprototype.Clone();
        }

        public override RoomWithBomb CreateRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Ожидается положительное число");
            }
            return _roomprototype.Clone();
        }

        public override Maze CreateMaze()
        {
            return _mazeprototype.Clone();
        }

        public override Door CreateDoor(Room room1, Room room2)
        {
            if (room1 == null)
                throw new ArgumentNullException(nameof(room1));
            if (room2 == null)
                throw new ArgumentNullException(nameof(room2));
            return _doorprototype.Clone();
        }
    }
}
