using UnityEngine;

public class CardManager : MonoBehaviour
{
    public static CardManager Instance;

    [SerializeField] private GameObject _cardPrefab;

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
    public GameObject SpawnCard(CardInstance cardInstance, Transform parentTransform)
    {
        GameObject spawnedCard = Instantiate(_cardPrefab, parentTransform.position, parentTransform.rotation);
        spawnedCard.GetComponent<CardDisplay>().SetupVisual(cardInstance);
        return spawnedCard;
    }
}
