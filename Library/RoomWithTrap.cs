using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class RoomWithTrap:Room
    {
        public RoomWithTrap(int Number) : base(Number) { }
        public RoomWithTrap() { }
        public override void Enter()
        {
            Console.WriteLine("Вы вошли в комнату с ловушкой.");
        }

        public void TriggerTrap()
        {
            Console.WriteLine("Вы попали в ловушку и были возвращены в начало лабиринта.");
        }
        public virtual RoomWithTrap Clone()
        {

            RoomWithTrap clonedRoom = (RoomWithTrap)base.Clone();
            RoomWithTrap roomWithTrapClone = new RoomWithTrap(roomNumber);

            return roomWithTrapClone;
        }
    }
}