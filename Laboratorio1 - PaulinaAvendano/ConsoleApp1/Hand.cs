using System;
using System.Collections.Generic;
using System.Text;

namespace Card
{
    class Hand
    {
        List<CombatCard> combatCards = new List<CombatCard>();
        List<SpecialCard> specialCards = new List<SpecialCard>();

        public List<CombatCard> CombatCards { get => combatCards; }
        public List<SpecialCard> SpecialCards { get => specialCards; }

        public void AddCombatCard(CombatCard combatCard) { }
        public void AddSpecialCard(SpecialCard specialCard) { }
        public void DestroyCombatCard(int cardId) { }
        public void DestroySpecialCard(int cardId) { }
    }
}
