using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Character
    {
        public Character target;
        public int HP;
        public int MP;
        public int damage;
        public void Attack()
        {
            target.MP -= damage;
        }

    }
}
