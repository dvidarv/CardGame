using UnityEngine;
using System.Collections.Generic;

public class DeckManager : MonoBehaviour
{
    public static DeckManager Instance;

    public GameObject _deckPrefab;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SpawnDeck(DeckInstance deckInstance, Transform _deckParentTransform)
    {
        GameObject spawnedDeck = Instantiate(_deckPrefab, _deckParentTransform);

        DeckDisplay display = spawnedDeck.GetComponent<DeckDisplay>();
        display.Setup(deckInstance);
    }

}
