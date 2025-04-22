using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CardGameManager : MonoBehaviour
{
    [HideInInspector]
    public static CardGameManager Instance;

    [SerializeField] private Transform _hunterDeckTransform;
    [SerializeField] private Transform _monsterDeckTransform;

    [SerializeField] private Transform _playerHandTransform;
    [SerializeField] private Transform _enemyHandTransform;

    List<CardInstance> playerCards = new List<CardInstance>();
    List<CardInstance> enemyCards = new List<CardInstance>();

    HandInstance playerHand;
    HandInstance enemyHand;
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
            CardInstance testCard = new CardInstance(CardLibrary.AllHunterCardsList[Random.Range(0, CardLibrary.AllHunterCardsList.Count)]);
            playerCards.Add(testCard);

            testCard = new CardInstance(CardLibrary.AllMonsterCardsList[Random.Range(0, CardLibrary.AllMonsterCardsList.Count)]);
            enemyCards.Add(testCard);
        }

        playerHand = new HandInstance();
        DeckInstance deck = new DeckInstance(playerCards);
        
        DeckManager.Instance.SpawnDeck(deck, _hunterDeckTransform);
        playerHand.RegisterToDeck(deck);
        HandManager.Instance.SpawnHand(playerHand, _playerHandTransform);

        
        enemyHand = new HandInstance();
        DeckInstance enemyDeck = new DeckInstance(enemyCards);
        
        DeckManager.Instance.SpawnDeck(enemyDeck, _monsterDeckTransform);
        enemyHand.RegisterToDeck(enemyDeck);
        HandManager.Instance.SpawnHand(enemyHand, _enemyHandTransform);



    }

}
