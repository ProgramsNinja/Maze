using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Лаб1
{
    public abstract class MazeFactory
    {
        public virtual Maze CreateMaze() => new Maze();
        public virtual Room CreateRoom(int number) => new Room(number);
        public virtual Wall CreateWall() => new Wall();
        public virtual Door CreateDoor(Room room1, Room room2) => new Door(room1, room2);
    }
}
