using Unity.VisualScripting;
using UnityEngine;

public class DeckDisplay : MonoBehaviour
{

    public void DisplayDeck<T>(DeckInstance<T> deckInstance, GameObject cardPrefab) where T: CardSO
    {
        float i = 0; 
        foreach(var card in deckInstance.GetCards())
        {
            GameObject cardInstance = Instantiate(cardPrefab, transform.position + new Vector3(0f, i, 0f), transform.rotation);
            i += 0.02f ;
            CardDisplay cardDisplay = cardInstance.GetComponent<CardDisplay>();
            cardDisplay.Setup(card);
        }
    }
    public void UpdateDeckDisplay()
    {

    }
}
