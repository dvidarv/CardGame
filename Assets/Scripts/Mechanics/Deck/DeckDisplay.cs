using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeckDisplay : MonoBehaviour, IClickable, IHoverable
{
    DeckInstance _deckInstance;

    [SerializeField] private GameObject _cardTypePrefab;
    [SerializeField] private Transform _cardParentTransform;
    [SerializeField] private float _yOffset = 0.02f;

    private List<GameObject> _visualCards = new List<GameObject>();

    public void Setup(DeckInstance deck)
    {
        _deckInstance = deck;
        foreach (var card in _visualCards)
        {
            Destroy(card);
        }
        _visualCards.Clear();

        for (int i = 0; i < _deckInstance.cards.Count; i++)
        {
            GameObject cardVisual = Instantiate(_cardTypePrefab, _cardParentTransform);
            cardVisual.transform.localPosition = new Vector3(0, i * _yOffset, 0);
            _visualCards.Add(cardVisual);
        }
    }

    public void AddCardVisual()
    {
        GameObject cardVisual = Instantiate(_cardTypePrefab, _cardParentTransform);
        cardVisual.transform.localPosition = new Vector3(0, _visualCards.Count * _yOffset, 0);
        _visualCards.Add(cardVisual);
    }

    public void RemoveCardVisual()
    {
        if (_visualCards.Count == 0) return;

        GameObject topCard = _visualCards[_visualCards.Count - 1];
        _visualCards.RemoveAt(_visualCards.Count - 1);
        Destroy(topCard);
    }

    public void OnHoverEnter()
    {
        Debug.Log("Entered Hover " + this.gameObject.name);
    }

    public void OnHoverExit()
    {
        Debug.Log(" Exited Hover " + this.gameObject.name);
    }

    public void OnLeftClick()
    {
        Debug.Log(" Left clicked " + this.gameObject.name);
        RemoveCardVisual();
    }

    public void OnRightClick()
    {
        Debug.Log(" Right Clicked  " + this.gameObject.name);
    }
}
