using TMPro;
using UnityEngine;

public class WeaponCardDisplay : CardDisplay
{
    [SerializeField] private TextMeshPro _cardAttackValue;

    public override void Setup(CardSO card)
    {
        base.Setup(card);

        WeaponCardSO cardData = card as WeaponCardSO;
        if (cardData == null)
        {
            return;
        }

        _cardAttackValue.text = cardData.cardAttackValue.ToString();
    }
}
