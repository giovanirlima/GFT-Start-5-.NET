using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCsharp.Entities
{
    public class Devil : Hero
    {
        public string TypeHero { get; set; }

        public Devil()
        {
        }

        public Devil(string name, int level, int hp, int mp, string typeHero) : base(name, level, hp, mp)
        {
            TypeHero = typeHero;
        }

        public override string BasicAttack()
        {
            return $"{TypeHero} - {Name} usou chamas mortiferas!";
        }

        public override string ComboAttack(int Damage)
        {
            if (Damage > 10)
            {
                return $"{TypeHero} - {Name} Lançou chamas negras com super crítico!";
            }
            else
            {
                return $"{TypeHero} - {Name} Lançou chamas negras não tão efetiva!";
            }
        }

        public override string ToString()
        {
            return $"Personagem escolhido:\nNome: {Name} \nNivel: {Level}\nHP: {Hp}\n MP: {Mp} \nClasse: {TypeHero}\n\nBom game!\n";
        }
    }
}
