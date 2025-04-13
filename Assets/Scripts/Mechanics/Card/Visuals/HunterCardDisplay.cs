using TMPro;
using UnityEngine;

public class HunterCardDisplay : CardDisplay
{
    [SerializeField] private TextMeshPro _cardAttackValue;
    [SerializeField] private TextMeshPro _cardHealthValue;

    public override void Setup(CardSO card)
    {
        base.Setup(card);

        HunterCardSO cardData = card as HunterCardSO;
        if (cardData == null)
        {
            return;
        }

        _cardAttackValue.text = cardData.cardAttackValue.ToString();
        _cardHealthValue.text = cardData.cardHealthValue.ToString();
    }
}
