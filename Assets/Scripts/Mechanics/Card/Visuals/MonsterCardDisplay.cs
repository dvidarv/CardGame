using TMPro;
using UnityEngine;

public class MonsterCardDisplay : CardDisplay
{
    [SerializeField] private TextMeshPro _cardAttackValue;
    [SerializeField] private TextMeshPro _cardHealthValue;

    public override void Setup(CardSO card)
    {
        base.Setup(card);

        MonsterCardSO cardData = card as MonsterCardSO;
        if(cardData == null)
        {
            return;
        }

        _cardAttackValue.text = cardData.cardAttackValue.ToString();
        _cardHealthValue.text = cardData.cardHealthValue.ToString();
    }
}
