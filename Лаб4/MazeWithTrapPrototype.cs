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
        protected MazeWithTrapPrototype()
            : base(new RoomWithTrap(), new DoorWithTrap() ,new Wall() ,new Maze() )
        {
        }
    }
}
