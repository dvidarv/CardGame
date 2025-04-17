using System;
using UnityEngine;

public enum CardType
{
    Hunter,
    Monster
}

[CreateAssetMenu(fileName = "HunterCard", menuName = "Scriptable Objects/Card")]
public class CardSO : ScriptableObject
{
    public CardType cardType;
    public string cardName;
    public int attackValue;
    public int healthValue;
}
