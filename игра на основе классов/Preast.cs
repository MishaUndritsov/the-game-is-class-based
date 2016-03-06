using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Preast : Character
    {
        public Preast(int Hp, int Mp, int damage)
        {
            this.Hp = Hp;
            this.Mp = Mp;
            this.Damage = damage;
        }
    }
}
