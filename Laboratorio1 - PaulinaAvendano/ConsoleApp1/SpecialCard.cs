using System;
using System.Collections.Generic;
using System.Text;

namespace Card
{
    class SpecialCard
    {
        public string name;
        public string type;
        public string buffType;
        public string effect;

        public SpecialCard()
        {

        }
        public string Name { get => name; }
        public string Type { set => Type = value; }
        public string BuffType { set => buffType = value; }
        public string Effect { get => effect; }
    }
}
