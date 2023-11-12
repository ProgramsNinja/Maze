using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public  class Maze
    {        
        private List<Room> _rooms = new List<Room>();

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public Room RoomNo(int number)
        {
            return _rooms.Single(room => room.roomNumber == number);
        }
        public virtual Maze Clone()
        {
            return (Maze)this.MemberwiseClone();
        }
    }
}
