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

        protected MazeFactoryPrototype(Room roomprototype, Door doorprototype, Wall wallprototype, Maze mazeprototype)
        {
            ArgumentNullException.ThrowIfNull(roomprototype);
            ArgumentNullException.ThrowIfNull(doorprototype);
            ArgumentNullException.ThrowIfNull(wallprototype);
            ArgumentNullException.ThrowIfNull(mazeprototype);
            _roomprototype = roomprototype;
            _doorprototype = doorprototype;
            _wallprototype = wallprototype;
            _mazeprototype = mazeprototype;
        }

        public MazeFactoryPrototype() : this(new Room(), new Door(), new Wall(), new Maze()) { }

        public override Maze CreateMaze() => _mazeprototype.Clone();
        public override Room CreateRoom(int roomNumber)
        {
            Room room = (Room)_roomprototype.Clone();
            if (roomNumber <= 0)
            {
                throw new ArgumentOutOfRangeException("Номер комнаты не соответствует условию");
            }
            room.Initialize(roomNumber);
            return room;
        }
        public override Wall CreateWall() => _wallprototype.Clone();
        public override Door CreateDoor(Room room1, Room room2)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException();
            }
            if (room2 == null)
            {
                throw new ArgumentNullException();
            }
            Door door = (Door)_doorprototype.Clone();
            door.Initialize(room1, room2);
            return door;
        }
    }
}
