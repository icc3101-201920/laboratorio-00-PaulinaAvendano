using System;
using System.Collections.Generic;
using System.Text;

namespace Card
{
    class Player
    {
        public int lifePoints;
        public int attackPoints;
        public Board board;
        public SpecialCard captain;
        public Deck deck;
        public Hand hand;

        public int LifePoints { get => lifePoints; }
        public int AttackPoints { get => attackPoints; }
        public SpecialCard Captain { set => captain = value; }
        public Deck Deck { get => deck ; }
        public Hand Hand { get => hand; }

        public void DrawCard() { }
        public void PlayCard(int cardId) { }
        public void ChangeCard(int cardId) { }
        public void FirstHand() { }
        public void ChooseCaptainCard(SpecialCard captainCard) { }
    }
}
