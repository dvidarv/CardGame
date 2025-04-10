using UnityEngine;

public class WeaponCardInstance: CardInstance
{
    // DEFAULT VALUES CAN BE UPGRADED, AND WILL REMAIN TILL THE END OF THE GAME
    private int _defaultAttackValue;

    // CURRENT VALUES ARE FOR BATTLE. THEY ARE RESET TO THE DEFAULT VALUE ONCE A BATTLE IS OVER
    private int _currentAttackValue;
    public WeaponCardInstance(WeaponCardSO cardData) : base(cardData)
    {
        _defaultAttackValue = cardData.cardAttackValue;
    }

    public override void ResetCard()
    {
        _currentAttackValue = _defaultAttackValue;
    }
}
