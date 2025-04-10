using UnityEngine;

public class ItemCardInstance: CardInstance
{
    // DEFAULT VALUES CAN BE UPGRADED, AND WILL REMAIN TILL THE END OF THE GAME
    private int _defaultHealthValue;

    // CURRENT VALUES ARE FOR BATTLE. THEY ARE RESET TO THE DEFAULT VALUE ONCE A BATTLE IS OVER
    private int _currentHealthValue;
    public ItemCardInstance(ItemCardSO cardData) : base(cardData)
    {
        _defaultHealthValue = cardData.cardHealthValue;
    }

    public override void ResetCard()
    {
        _currentHealthValue = _defaultHealthValue;
    }
}
