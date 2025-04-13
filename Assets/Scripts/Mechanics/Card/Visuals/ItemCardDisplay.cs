using TMPro;
using UnityEngine;

public class ItemCardDisplay : CardDisplay
{
    [SerializeField] private TextMeshPro _cardHealthValue;

    public override void Setup(CardSO card)
    {
        base.Setup(card);

        ItemCardSO cardData = card as ItemCardSO;
        if (cardData == null)
        {
            return;
        }

        _cardHealthValue.text = cardData.cardHealthValue.ToString();
    }
}
