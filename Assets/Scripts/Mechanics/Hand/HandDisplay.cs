using System.Collections.Generic;
using UnityEngine;

public class HandDisplay : MonoBehaviour
{
    HandInstance _handInstance;

    private List<GameObject> _visualCards = new List<GameObject>();
    public void Setup(HandInstance hand)
    {
        _handInstance = hand;

        hand.OnCardAdded += AddCardVisual;

        foreach(GameObject gameObject in _visualCards)
        {
            Destroy(gameObject);
        }
        _visualCards.Clear();

        for (int i = 0; i < _handInstance.cards.Count; i++)
        {
            CardManager.Instance.SpawnCard(_handInstance.cards[i], transform);
        }
    }

    public void AddCardVisual(CardInstance cardInstance)
    {
        GameObject cardVisualSpawned;
        cardVisualSpawned = CardManager.Instance.SpawnCard(cardInstance, transform);
        _visualCards.Add(cardVisualSpawned);
    }

    public void PlayCardVisual(Transform targetTransform)
    {
        if (_visualCards.Contains(this.gameObject))
        {
            _visualCards.Remove(this.gameObject);
        }
    }
}
