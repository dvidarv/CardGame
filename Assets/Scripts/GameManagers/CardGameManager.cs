using UnityEngine;

public class CardGameManager : MonoBehaviour
{
    [HideInInspector]
    public static CardGameManager Instance;

    private DeckInstance<HunterCardSO> _hunterDeck;
    private DeckInstance<MonsterCardSO> _monsterDeck;
    private DeckInstance<WeaponCardSO> _weaponDeck;
    private DeckInstance<ItemCardSO> _itemDeck;


    [SerializeField] private Transform _hunterDeckTransform;
    [SerializeField] private Transform _monsterDeckTransform;
    [SerializeField] private Transform _weaponDeckTransform;
    [SerializeField] private Transform _itemDeckTransform;
    
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
        
        CardLibrary.InitCardLibrary();
    }

    private void Start()
    {
        _monsterDeck = new DeckInstance<MonsterCardSO>(CardLibrary.AllMonsterCards, 5);
        DeckManager.Instance.DisplayDeck<MonsterCardSO>(_monsterDeck, _monsterDeckTransform);

        _hunterDeck = new DeckInstance<HunterCardSO>(CardLibrary.AllHunterCards, 5);
        DeckManager.Instance.DisplayDeck<HunterCardSO>(_hunterDeck, _hunterDeckTransform);

        _weaponDeck = new DeckInstance<WeaponCardSO>(CardLibrary.AllWeaponCards, 2);
        DeckManager.Instance.DisplayDeck<WeaponCardSO>(_weaponDeck, _weaponDeckTransform);

        _itemDeck = new DeckInstance<ItemCardSO>(CardLibrary.AllItemCards, 2);
        DeckManager.Instance.DisplayDeck<ItemCardSO>(_itemDeck, _itemDeckTransform);
    }
}
