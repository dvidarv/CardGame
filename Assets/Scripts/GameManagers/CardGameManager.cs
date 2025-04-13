using UnityEngine;

public class CardGameManager : MonoBehaviour
{
    [HideInInspector]
    public CardGameManager Instance;

    [SerializeField] private GameObject _cardPrefab;
    [SerializeField] private Transform _deckTransform;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
        CardLibrary.InitCardLibrary();
    }

    private void Start()
    {
        DeckManager.Instance.CreateDeck<MonsterCardSO>(CardLibrary.AllMonsterCards, _cardPrefab, 5, _deckTransform);
    }
}
