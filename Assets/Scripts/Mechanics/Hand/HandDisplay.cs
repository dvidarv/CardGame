using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;

public class HandDisplay : MonoBehaviour
{
    HandInstance _handInstance;

    private List<GameObject> _visualCards = new List<GameObject>();
    [SerializeField] private Transform _cardSpawnPoint;
    [SerializeField] private Transform _handLookToTransform;
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
            //UpdateCardPositions();
            UpdateCardLine();
        }
    }

    public void AddCardVisual(CardInstance cardInstance)
    {
        GameObject cardVisualSpawned;
        cardVisualSpawned = CardManager.Instance.SpawnCard(cardInstance, _cardSpawnPoint);
        _visualCards.Add(cardVisualSpawned);
        //UpdateCardPositions();
        UpdateCardLine();

    }
    private void UpdateCardLine()
    {
        float spacing = 0.3f;
        int count = _visualCards.Count;
        float startX = -((count - 1) * spacing) / 2f;

        for (int i = 0; i < count; i++)
        {
            Vector3 cardPos = transform.position + new Vector3(startX + i * spacing, 0, 0);
            Quaternion cardRotation = Quaternion.LookRotation(_handLookToTransform.forward, Vector3.up);

            _visualCards[i].transform.DOMove(cardPos, 0.25f);
            _visualCards[i].transform.DORotateQuaternion(cardRotation, 0.25f);
        }
    }





    public void PlayCardVisual(Transform targetTransform)
    {
        if (_visualCards.Contains(this.gameObject))
        {
            _visualCards.Remove(this.gameObject);
        }
    }
}
