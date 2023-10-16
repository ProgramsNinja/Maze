﻿using Library;
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

        public override void Enter()
        {
            Console.WriteLine("Вы вошли в комнату с ловушкой.");
        }

        public void TriggerTrap()
        {
            Console.WriteLine("Вы попали в ловушку и были возвращены в начало лабиринта.");
        }
    }
}