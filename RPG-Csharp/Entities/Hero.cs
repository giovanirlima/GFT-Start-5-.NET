using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGCsharp.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }


        public Hero()
        {
        }

        public Hero(string name, int level, int hp, int mp)
        {
            Name = name;
            Level = level;
            Hp = hp;
            Mp = mp;
        }

        public abstract string BasicAttack();

        public abstract string ComboAttack(int Damage);


    }
}

