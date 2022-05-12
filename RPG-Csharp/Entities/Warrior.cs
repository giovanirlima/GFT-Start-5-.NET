using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCsharp.Entities
{
    public class Warrior : Hero
    {
        public string TypeHero { get; set; }

        public Warrior()
        {
        }

        public Warrior(string name, int level, int hp, int mp, string typeHero) : base(name, level, hp, mp)
        {
            TypeHero = typeHero;
        }

        public override string BasicAttack()
        {
            return $"{TypeHero} - {Name} usou ataque de fúria!";
        }

        public override string ComboAttack(int Damage)
        {
            if(Damage > 10)
            {
                return $"{TypeHero} - {Name} acertou um combo com super crítico!";
            }
            else
            {
                return $"{TypeHero} - {Name} acertou um combo não tão efetívo!";
            }
        }

        public override string ToString()
        {
            return $"Personagem escolhido:\nNome: {Name} \nNivel: {Level}\nHP: {Hp}\n MP: {Mp} \nClasse: {TypeHero}\n\nBom game!\n";
        }
    }
}
