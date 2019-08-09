using System;
using System.Collections.Generic;
using System.Text;

namespace Card
{
    class Board
    {
        List<CombatCard> meeleCards = new List<CombatCard>();
        List<CombatCard> rangeCards = new List<CombatCard>();
        List<CombatCard> longRangeCards = new List<CombatCard>();

        public SpecialCard specialMeeleCards;
        public SpecialCard specialRangeCards;
        public SpecialCard specialLongRangeCards;

        List<SpecialCard> captainCards = new List<SpecialCard>();
        List<SpecialCard> weatherCards = new List<SpecialCard>();

        public List<CombatCard> MeeleCards { get => meeleCards; }
        public List<CombatCard> RangeCards { get => rangeCards; }
        public List<CombatCard> LongRangeCards { get => longRangeCards; }
        public List<SpecialCard> CaptainCards { get => captainCards; }
        public List<SpecialCard> WeatherCards { get => weatherCards; }

        public SpecialCard SpecialRangeCards { get => specialRangeCards; }
        public SpecialCard SpecialLongRangeCards { get => specialLongRangeCards; }

        public void AddCombatCard(int playerId, CombatCard combatCard)
        {

        }
        public void AddSpecialCard(int playerId, SpecialCard specialCard)
        {

        }
        public void DestroyCombatCards() { }
        public void DestroySpecialCards() { }

        private int meeleAttackPoints;
        private int rangeAttackPoints;
        private int longRangeAttackPoints;

        public int GetMeeleAttackPoints()
        {
            return meeleAttackPoints;
        }
        public int GetRangeAttackPoints()
        {
            return rangeAttackPoints;
        }
        public int GetLongRangeAttackPoints()
        {
            return longRangeAttackPoints;
        }

    }
}
