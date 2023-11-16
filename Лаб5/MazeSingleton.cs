using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Лаб1;

namespace Лаб5
{
    public class MazeSingleton:MazeFactory
    {
        private static MazeSingleton _instance;
        private MazeSingleton(){ }
        public static MazeSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MazeSingleton();
            }
            return _instance;
        }
    }
}
