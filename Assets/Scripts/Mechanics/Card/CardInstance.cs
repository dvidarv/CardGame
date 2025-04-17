using UnityEngine;

public class CardInstance
{
    private CardSO cardData;

    public string _cardName;
    public CardType _cardType;
    public int _cardDefaultAttackValue;
    public int _cardDefaultHealthValue;
    public int _cardCurrentAttackValue;
    public int _cardCurrentHealthValue;
    public CardInstance(CardSO cardData)
    {
        this.cardData = cardData;
        _cardName = cardData.cardName;
        _cardType = cardData.cardType;
        _cardDefaultAttackValue = cardData.attackValue;
        _cardDefaultHealthValue = cardData.healthValue;
        ResetCard();
    }
    public void ResetCard()
    {
        _cardCurrentAttackValue = _cardDefaultAttackValue;
        _cardCurrentHealthValue = _cardDefaultHealthValue;
    }

    public void TakeDamage(int amount)
    {
        _cardCurrentHealthValue -= amount;
    }
}
