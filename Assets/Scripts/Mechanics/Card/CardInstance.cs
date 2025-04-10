using UnityEngine;

public abstract class CardInstance
{
    private CardSO cardData;
    public CardInstance(CardSO cardData)
    {
        this.cardData = cardData;
    }
    public abstract void ResetCard();
}
