using UnityEngine;
using System.Collections.Generic;

public class DeckManager : MonoBehaviour
{
    [HideInInspector]
    public static DeckManager Instance;

    [SerializeField] private GameObject _deckVisualPrefab;

    [Header("Card Prefabs by Type")]
    [SerializeField] private GameObject _monsterCardPrefab;
    [SerializeField] private GameObject _hunterCardPrefab;
    [SerializeField] private GameObject _weaponCardPrefab;
    [SerializeField] private GameObject _itemCardPrefab;

    private Dictionary<System.Type, GameObject> _cardPrefabs;

    private void Awake()
    {
        if (Instance == null) 
            Instance = this;
        else
        { 
            Destroy(gameObject); return; 
        }

        _cardPrefabs = new Dictionary<System.Type, GameObject>
        {
            { typeof(MonsterCardSO), _monsterCardPrefab },
            { typeof(HunterCardSO), _hunterCardPrefab },
            { typeof(WeaponCardSO), _weaponCardPrefab },
            { typeof(ItemCardSO), _itemCardPrefab }
        };
    }

    private GameObject GetPrefabForCardType<T>() where T : CardSO
    {
        if (_cardPrefabs.TryGetValue(typeof(T), out var prefab))
        {
            return prefab;
        }

        Debug.LogError($"No prefab registered for card type {typeof(T).Name}");
        return null;
    }

    public void DisplayDeck<T>(DeckInstance<T> deck, Transform deckTransform) where T : CardSO
    {
        var cardPrefab = GetPrefabForCardType<T>();
        if (cardPrefab == null) return;

        // Instantiate DeckVisual
        GameObject deckVisualInstance = Instantiate(_deckVisualPrefab, deckTransform);
        DeckDisplay deckDisplay = deckVisualInstance.GetComponent<DeckDisplay>();

        deckDisplay.DisplayDeck(deck, cardPrefab);
    }
}
