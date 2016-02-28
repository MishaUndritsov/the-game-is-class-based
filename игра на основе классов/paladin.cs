using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class paladin : Character
    {
        public paladin(int HP, int MP, int damage)
        {
            this.HP = HP;
            this.MP = MP;
            this.damage = damage;
        }
    }
}
