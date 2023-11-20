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
            Maze clonedMaze = (Maze)this.MemberwiseClone();
            clonedMaze._rooms = new List<Room>(_rooms.Count); 

            foreach (Room room in _rooms)
            {
                Room clonedRoom = room.Clone(); 
                clonedMaze.AddRoom(clonedRoom); 
            }

            return clonedMaze;
        }
    }
}
