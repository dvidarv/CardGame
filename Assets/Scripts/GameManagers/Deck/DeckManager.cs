using UnityEngine;
using System.Collections.Generic;

public class DeckManager : MonoBehaviour
{
    [HideInInspector]
    public static DeckManager Instance;

    [SerializeField] private GameObject _deckVisualPrefab;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CreateDeck<T>(List<T> cardPool, GameObject cardPrefab, int deckSize, Transform deckTransform) where T : CardSO
    {
        if (cardPool == null || cardPool.Count == 0)
        {
            Debug.LogWarning($"No cards found for type {typeof(T).Name}.");
            return;
        }

        // Create DeckInstance
        DeckInstance<T> deck = new DeckInstance<T>(cardPool, deckSize);

        // Instantiate DeckVisual
        GameObject _deckVisualInstance = Instantiate(_deckVisualPrefab, deckTransform);
        DeckDisplay deckDisplay = _deckVisualInstance.GetComponent<DeckDisplay>();

        deckDisplay.DisplayDeck(deck, cardPrefab);
    }
}
