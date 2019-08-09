using System;
using System.Collections.Generic;
using System.Text;

namespace Card
{
    class CombatCard
    {
        public string name;
        public int attackPoints;
        public bool hero;
        public string type;
        public string effect;

        public CombatCard()
        {

        }

        public string Name { get => name; }
        public bool Hero { set => hero = value; }
        public int AttackPoints { get => attackPoints; }
        public string Type { set => Type = value; }
        public string Effect {get => effect; }
    }
}
