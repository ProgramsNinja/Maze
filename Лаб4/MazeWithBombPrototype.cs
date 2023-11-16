using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Лаб1;

namespace Лаб4
{
    public class MazeWithBombPrototype : MazeFactoryPrototype
    {
        protected MazeWithBombPrototype()
             : base(new RoomWithBomb() , new Door() , new WallWithBomb(),  new Maze())
        {
        }

    }
}
