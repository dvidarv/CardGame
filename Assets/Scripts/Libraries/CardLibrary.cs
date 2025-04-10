using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class CardLibrary
{
    public static List<CardSO> AllCardsList {  get; private set; }
    public static List<MonsterCardSO> AllMonsterCards { get; private set; }
    public static List<HunterCardSO> AllHunterCards { get; private set; }
    public static List<WeaponCardSO> AllWeaponCards { get; private set; }
    public static List<ItemCardSO> AllItemCards { get; private set; }

    public static void InitCardLibrary()
    {
        CardSO[] AllCardsArray = Resources.LoadAll<CardSO>("Cards");
        AllCardsList = new List<CardSO>(AllCardsArray);

        AllMonsterCards = new List<MonsterCardSO>(AllCardsList.OfType<MonsterCardSO>());
        AllHunterCards = new List<HunterCardSO>(AllCardsList.OfType<HunterCardSO>());
        AllWeaponCards = new List<WeaponCardSO>(AllCardsList.OfType<WeaponCardSO>());
        AllItemCards = new List<ItemCardSO>(AllCardsList.OfType<ItemCardSO>());
    }
    public static void PrintCardsOfType<T>(List<T> cards) where T : CardSO
    {
        foreach (var card in cards)
        {
            Debug.Log("Card: " + card.name);
        }
    }
}
