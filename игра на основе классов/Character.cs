using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Character
    {
        public Character target;
        private int hp;

        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        private int mp;

        public int Mp
        {
            get { return mp; }
            set { mp = value; }
        }
        private int damage;

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public void Attack()
        {
            target.Mp -= damage;
        }

    }
}
