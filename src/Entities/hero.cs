using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo.src.Entities
{
    public class hero
    {
        public hero(string name, string classeHeroi, int level, int hp, int mana)
        {
            this.Name = name;
            this.Level = level;
            this.ClasseHeroi = classeHeroi;
            this.Hp = hp;
            this.Mana = mana;
        }
        public hero()
        {

        }
        public string Name;

        public int Level;

        public string ClasseHeroi;

        public int Hp;

        public int Mana;

        public override string ToString()
        {
            return "NOME:"+ this.Name + " LEVEL:" + this.Level + " CLASSE:" + this.ClasseHeroi;
        }
        public virtual String attack()
        {
            return this.Name + " Atacou com a sua Adaga!";
        }
        public String attack(int bonus)
        {
            if (bonus >= 5)
            {
                return this.Name + " Acertou sua Adaga com Critical de " + bonus + " dano!";
            }
            else
            {
                return this.Name + " Acertou sua Adaga com Critical Master de " + bonus + " dano!";
            }

        }
    }
}