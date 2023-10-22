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
        public override Wall CreateWall()
        {
            return new WallWithBomb();
        }

        public override Room CreateRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Ожидается положительное число");
            }
            return new RoomWithBomb(number);
        }

        public ICloneablePrototype Clone() => (ICloneablePrototype)MemberwiseClone();
    }
}
