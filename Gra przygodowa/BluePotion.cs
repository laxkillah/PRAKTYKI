﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_przygodowa
{
    class BluePotion : Weapon, IPotion
    {
        public BluePotion(Game game, Point location) : base(game, location) { Used = false; }

        public override string Name { get { return "Niebieska mikstura"; } }

        public bool Used { get; private set; }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            Used = true;
        }
    }
}
