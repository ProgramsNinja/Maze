using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб3
{
    public class MazeWithBombGame : MazeGame
    {
        public override Room CreateRoom(int number)
        {
            if (number < -0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Ожидается положительное число");
            }
            return new RoomWithBomb(number);
        }

        public override Wall CreateWall()
        {
            return new WallWithBomb();
        }
    }
}
