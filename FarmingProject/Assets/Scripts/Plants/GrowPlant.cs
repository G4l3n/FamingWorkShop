using UnityEngine;
using UnityEngine.Events;

public class GrowPlant : Plants
{
    [HideInInspector] public int AmountOfThisPlant { get; private set; }
    [SerializeField] private UnityEvent _carrotsGrown;
    [SerializeField] private UnityEvent WheatGrown;

    private void Start()
    {
        NameOfThisPlant = Scriptable.Name;
        PlantSellPrice = Scriptable.SellPlantPrice;
        CostOfThisPlant = Scriptable.BuyPlantCost;
        if (NameOfThisPlant == _inventory.NameOfCarrots)
        {
            AmountOfThisPlant = _inventory.amountOfCarrotsPlants;
        }
        if (NameOfThisPlant == _inventory.NameOfWheat)
        {
            AmountOfThisPlant = _inventory.amountOfWheatPlants;
        }
    }

    public void PlantAsGrown()
    {
        if (NameOfThisPlant == _inventory.NameOfCarrots)
        {
            _inventory.amountOfCarrotsPlants += Scriptable.AmountOfPlantArvested;
            AmountOfThisPlant = _inventory.amountOfWheatPlants;
            _carrotsGrown?.Invoke();
        }
        if (NameOfThisPlant == _inventory.NameOfWheat)
        {
            _inventory.amountOfWheatPlants += Scriptable.AmountOfPlantArvested;
            AmountOfThisPlant = _inventory.amountOfWheatPlants;
            WheatGrown?.Invoke();
        }
    }
}
