using UnityEngine;
using UnityEngine.Events;

public class Seeds : Plants
{
    [HideInInspector] public int AmountOfThisSeed { get; private set; }
    [SerializeField] private UnityEvent _carrotsSeedsGrown;
    [SerializeField] private UnityEvent _wheatSeedsGrown;

    private void Start()
    {
        NameOfThisSeed = Scriptable.Name;
        CostOfThisSeed = Scriptable.BuySeedCost;
        SeedSellPrice = Scriptable.SellSeedPrice;
        if (NameOfThisSeed == _inventory.NameOfCarrots)
        {
            AmountOfThisSeed = _inventory.amountOfCarrotsSeeds;
        }
        if (NameOfThisSeed == _inventory.NameOfWheat)
        {
            AmountOfThisSeed = _inventory.amountOfWheatSeeds;
        }  
    }

    public void PlantedSeed()
    {
        if (NameOfThisSeed == _inventory.NameOfCarrots)
        {
            _inventory.amountOfCarrotsSeeds -= 1;
            AmountOfThisSeed = _inventory.amountOfCarrotsSeeds;
            _carrotsSeedsGrown?.Invoke();
        }
        if (NameOfThisSeed == _inventory.NameOfWheat)
        {
            _inventory.amountOfWheatSeeds -= 1;
            AmountOfThisSeed = _inventory.amountOfWheatSeeds;
            _wheatSeedsGrown?.Invoke();
        }
    }
}
