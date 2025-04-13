using TMPro;
using UnityEngine;

public abstract class CardDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshPro _cardName;

    protected CardSO _cardData;

    public virtual void Setup(CardSO card)
    {
        _cardData = card;
        _cardName.text = card.cardName;
    }


}
