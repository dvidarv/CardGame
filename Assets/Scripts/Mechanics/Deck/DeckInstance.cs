using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class DeckInstance
{
    public List<CardInstance> cards;
    public DeckInstance()
    {
        cards = new List<CardInstance>();
    }
    public DeckInstance(List<CardInstance> cards)
    {
        this.cards = cards;
    }
    public void ShuffleDeck()
    {
        cards = cards.OrderBy(c => UnityEngine.Random.value).ToList();
    }

    public CardInstance DrawCard()
    {
        if(cards.Count > 0)
        {
            CardInstance topCard = cards[0];
            cards.RemoveAt(0);
            return topCard;
        }
        else
        {
            return null;
        }
    }
    
    public void AddCard(CardInstance card)
    {
        cards.Add(card);
    }
}
