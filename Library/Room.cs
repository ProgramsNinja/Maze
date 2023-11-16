using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Room : IMapSite
    { 
        protected IMapSite[] Sides { get; private init; }
        public int roomNumber { get; private set; }

        public Room(int roomNo)
        {
            if(roomNo<=0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNo), roomNo,"Ожидается положительное число");  
            }
            roomNumber = roomNo;
            Sides = new IMapSite[4];
        }
        public Room() { }
        public void Initialize(int Number)
        {
            roomNumber = Number;
        }
        public IMapSite GetSide(Direction direction)
        {
            return Sides[(int)direction];
        }

        public void SetSide(Direction direction, IMapSite side)
        {
            Sides[(int)direction] = side;
        }

        public virtual void Enter()
        {
            Console.WriteLine($"Мы вошли в комнату№ {roomNumber}");
        }
        public virtual Room Clone()
        {
            return (Room)this.MemberwiseClone();
        }
    }
}
