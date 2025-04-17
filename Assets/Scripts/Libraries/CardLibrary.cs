using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class CardLibrary
{
    public static List<CardSO> AllCardsList {  get; private set; }
    public static List<CardSO> AllMonsterCardsList {  get; private set; }
    public static List<CardSO> AllHunterCardsList { get; private set; }

    public static void InitCardLibrary()
    {
        CardSO[] AllCardsArray = Resources.LoadAll<CardSO>("Cards");
        
        AllCardsList = new List<CardSO>(AllCardsArray);
        AllMonsterCardsList = AllCardsList.Where(card => card.cardType == CardType.Monster).ToList();
        AllHunterCardsList = AllCardsList.Where(card => card.cardType == CardType.Hunter).ToList();
    }
}
