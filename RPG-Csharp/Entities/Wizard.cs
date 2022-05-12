using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCsharp.Entities
{
    public class Wizard : Hero
    {
        public string TypeHero { get; set; }

        public Wizard()
        {
        }

        public Wizard(string name, int level, int hp, int mp, string typeHero) : base(name, level, hp, mp)
        {
            TypeHero = typeHero;
        }

        public override string BasicAttack()
        {
            return $"{TypeHero} - {Name} usou chuva de gelo!";
        }

        public override string ComboAttack(int Damage)
        {
            if (Damage > 10)
            {
                return $"{TypeHero} - {Name} Lançou chuva de gelo e obteve acerto super crítico!";
            }
            else
            {
                return $"{TypeHero} - {Name} Lançou chuva de gelo não tão efetivo!";
            }
        }

        public override string ToString()
        {
            return $"Personagem escolhido:\nNome: {Name} \nNivel: {Level}\nHP: {Hp}\n MP: {Mp} \nClasse: {TypeHero}\n\nBom game!\n";
        }
    }
}
