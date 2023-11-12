using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class RoomWithBomb : Room
    {
        private static Random Rnd = new Random();
        public RoomWithBomb(int number) : base(number) { }

        public override void Enter()
        {
            base.Enter();
            if (Rnd.Next(2) == 0)
            {
                Console.WriteLine("Взрыв!!");
                Sides.OfType<WallWithBomb>().ToList().ForEach(x => x.Explode());
            }
        }
        public virtual RoomWithBomb Clone()
        {
            return (RoomWithBomb)this.MemberwiseClone();
        }
    }
}
