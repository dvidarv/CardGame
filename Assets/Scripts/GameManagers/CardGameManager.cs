using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CardGameManager : MonoBehaviour
{
    [HideInInspector]
    public static CardGameManager Instance;

    [SerializeField] private Transform _hunterDeckTransform;
    [SerializeField] private Transform _monsterDeckTransform;

    List<CardInstance> cards = new List<CardInstance>();
    
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
        for(int i = 0; i < 5; i++)
        {
            CardInstance testCard = new CardInstance(CardLibrary.AllMonsterCardsList[Random.Range(0, CardLibrary.AllMonsterCardsList.Count)]);
            cards.Add(testCard);
        }
        DeckInstance deck = new DeckInstance(cards);

        DeckManager.Instance.SpawnDeck(deck, _monsterDeckTransform);
    }
}
