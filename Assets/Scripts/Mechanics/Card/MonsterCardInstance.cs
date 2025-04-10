using UnityEngine;

public class MonsterCardInstance : CardInstance
{
    // DEFAULT VALUES CAN BE UPGRADED, AND WILL REMAIN TILL THE END OF THE GAME
    private int _defaultAttackValue;
    private int _defaultHealthValue;

    // CURRENT VALUES ARE FOR BATTLE. THEY ARE RESET TO THE DEFAULT VALUE ONCE A BATTLE IS OVER
    private int _currentAttackValue;
    private int _currentHealthValue;
    public MonsterCardInstance(MonsterCardSO cardData) : base(cardData)
    {
        _defaultAttackValue = cardData.cardAttackValue;
        _defaultHealthValue = cardData.cardHealthValue;
    }

    public override void ResetCard()
    {
        _currentAttackValue = _defaultAttackValue;
        _currentHealthValue = _defaultHealthValue;
    }
}
