using Unity.VisualScripting;
using UnityEngine;

public class DeckDisplay : MonoBehaviour
{

    public void DisplayDeck<T>(DeckInstance<T> deckInstance, GameObject cardPrefab) where T: CardSO
    {
        foreach(var card in deckInstance.GetCards())
        {
            GameObject cardInstance = Instantiate(cardPrefab, transform);
            CardDisplay cardDisplay = cardInstance.GetComponent<CardDisplay>();
            cardDisplay.Setup(card);
        }
    }
    public void UpdateDeckDisplay()
    {

    }
}
