using System;
using System.Collections.Generic;
using UnityEngine;

public class HandInstance
{
    public List<CardInstance> cards;

    public Action<CardInstance> OnCardAdded;
    public HandInstance()
    {
        cards = new List<CardInstance>();
    }
    public void RegisterToDeck(DeckInstance deck)
    {
        deck.OnCardDrawn += AddCardFromDeck;
    }
    public CardInstance PlayCardToBoard(CardInstance cardInstance)
    {
        if (cards.Contains(cardInstance))
        {
            CardInstance selectedCard = cardInstance;
            cards.Remove(cardInstance);
            return selectedCard;
        }
        else
        {
            return null;
        }
    }

    public void AddCardFromDeck(CardInstance card)
    {
        cards.Add(card);
        OnCardAdded?.Invoke(card);
    }
}
