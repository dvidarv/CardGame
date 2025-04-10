using System;
using System.Collections.Generic;
using UnityEngine;

public class DeckInstance
{
    private List<CardSO> _deck;
    public DeckInstance(List<CardSO> cards, int deckSize)
    {
        _deck = new List<CardSO>();
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
}
