using TMPro;
using UnityEngine;

public class CardDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshPro _cardName;
    [SerializeField] private TextMeshPro _cardType;
    [SerializeField] private TextMeshPro _cardAttackValue;
    [SerializeField] private TextMeshPro _cardHealthValue;

    private CardInstance _cardInstance;

    public void SetupVisual(CardInstance cardInstance)
    {
        _cardInstance = cardInstance;
        
    }

    public void UpdateVisual()
    {
        _cardType.text = _cardInstance._cardType.ToString();
        _cardName.text = _cardInstance._cardName.ToString();
        _cardAttackValue.text = _cardInstance._cardCurrentAttackValue.ToString();
        _cardHealthValue.text = _cardInstance._cardCurrentHealthValue.ToString();
    }
}
