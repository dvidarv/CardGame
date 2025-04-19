using UnityEngine;

public class HandManager : MonoBehaviour
{
    public static HandManager Instance;

    public GameObject _handPrefab;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SpawnHand(HandInstance handInstance, Transform _handParentTransform)
    {
        GameObject spawnedHand = Instantiate(_handPrefab, _handParentTransform);

        HandDisplay display = spawnedHand.GetComponent<HandDisplay>();
        display.Setup(handInstance);
    }
}
