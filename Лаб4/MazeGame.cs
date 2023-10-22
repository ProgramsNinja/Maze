using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб4
{
   public class MazeGame
    {
        public Maze Create(MazeFactoryPrototype factory)
        {
            Maze maze = factory.CreateMaze();
            Room room1 = factory.CreateRoom(1);
            Room room2 = factory.CreateRoom(2);
            Door door = factory.CreateDoor(room1, room2);

            room1.SetSide(Direction.North, new Wall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, new Wall());
            room1.SetSide(Direction.West, new Wall());

            room2.SetSide(Direction.North, new Wall());
            room2.SetSide(Direction.East, new Wall());
            room2.SetSide(Direction.South, new Wall());
            room2.SetSide(Direction.West, door);
            maze.AddRoom(room1);
            maze.AddRoom(room2);

            return maze;
        }
    }
}
