using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб4
{
    public abstract class MazeFactoryPrototype:ICloneablePrototype
    {
        public virtual Maze CreateMaze() => new Maze();
        public virtual Room CreateRoom(int number) => new Room(number);
        public virtual Wall CreateWall() => new Wall();
        public virtual Door CreateDoor(Room room1, Room room2) => new Door(room1, room2);

        public ICloneablePrototype Clone() => (ICloneablePrototype)MemberwiseClone();
    }
}
