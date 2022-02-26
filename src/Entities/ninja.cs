using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo.src.Entities
{
    class ninja : hero
    {
        public ninja(string name, string classeHeroi, int level, int hp, int mana)
        {
            this.Name = name;
            this.Level = level;
            this.ClasseHeroi = classeHeroi;
            this.Hp = hp;
            this.Mana = mana;
        }
        public override String attack()
        {
            return this.Name + " Atacou com Soco!";
        }
        public String attack(int bonus)
        {
            if (bonus <= 5)
            {
                return this.Name + " Acertou Soco com Critical de " + bonus + " dano!";
            }
            else
            {
                return this.Name + " Acertou Soco com Critical Master de " + bonus + " dano!";
            }

        }
    }
}
