using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class WallWithBomb : Wall
    {
        private bool _isExploded = false;

        public void Explode()
        {
            if (!_isExploded)
            {
                Console.WriteLine("Стены разрушены!");
                _isExploded = true;
            }
        }
        public override void Enter()
        {
            if (_isExploded)
            {
                Console.WriteLine("Вы встретили разрушенную стену");
            }
            else
            {
                base.Enter();
            }
        }
    }
}
