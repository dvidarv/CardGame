using Mono.Cecil;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardLibrary
{
    public List<CardSO> AllCardsList {  get; private set; }
    public List<MonsterCardSO> AllMonsterCards { get; private set; }
    public List<HunterCardSO> AllHunterCards { get; private set; }
    public List<WeaponCardSO> AllWeaponCards { get; private set; }
    public List<ItemCardSO> AllItemCards { get; private set; }

    public void InitCardLibrary()
    {
        CardSO[] AllCardsArray = Resources.LoadAll<CardSO>("Cards");
        AllCardsList = new List<CardSO>(AllCardsArray);

        AllMonsterCards = new List<MonsterCardSO>(AllCardsList.OfType<MonsterCardSO>());
        AllHunterCards = new List<HunterCardSO>(AllCardsList.OfType<HunterCardSO>());
        AllWeaponCards = new List<WeaponCardSO>(AllCardsList.OfType<WeaponCardSO>());
        AllItemCards = new List<ItemCardSO>(AllCardsList.OfType<ItemCardSO>());
    }
    public void PrintCardsOfType<T>(List<T> cards) where T : CardSO
    {
        foreach (var card in cards)
        {
            Debug.Log("Card: " + card.name);
        }
    }
}
