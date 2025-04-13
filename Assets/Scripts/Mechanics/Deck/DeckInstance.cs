using System;
using System.Collections.Generic;
using UnityEngine;

public class DeckInstance<T> where T : CardSO
{
    private List<T> _deck;
    public DeckInstance(List<T> cards, int deckSize)
    {
        _deck = new List<T>();
        _deck.Clear();
        if(cards == null)
        {
            Debug.Log("Could not create deck. The list of provided cards is empty");
            return;
        }
        for (int i = 0; i < deckSize; i++)
        {
            _deck.Add(cards[UnityEngine.Random.Range(0, cards.Count)]);
        }
    }

    public void PrintDeck()
    {
        foreach (var card in _deck)
        {
            Debug.Log(card.name);
        }
    }

    public List<T> GetCards()
    {
        return _deck;
    }
}
