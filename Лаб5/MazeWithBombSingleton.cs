using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Лаб1;

namespace Лаб5
{
    public class MazeWithBombSingleton:MazeWithBombFactory
    {
        private static MazeWithBombSingleton _instance;
        private MazeWithBombSingleton(){ }
        public static MazeWithBombSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MazeWithBombSingleton();
            }
            return _instance;
        }
    }
}
