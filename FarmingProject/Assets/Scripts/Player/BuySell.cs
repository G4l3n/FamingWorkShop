using UnityEngine;
using UnityEngine.Events;

public class BuySell : MonoBehaviour
{
    [SerializeField] private Plants _plants;
    [SerializeField] private AddRemove _addRemove;
    [SerializeField] private Inventory _inventory;
    [SerializeField] private UnityEvent _carrotsPlantsChange;
    [SerializeField] private UnityEvent _wheatPlantsChange;
    [SerializeField] private UnityEvent _carrotsSeedsChange;
    [SerializeField] private UnityEvent _wheatSeedsChange;

    public void BuyPlants()
    {
        if (_inventory.money >= _addRemove.AmountToChange * _plants.CostOfThisPlant)
        {
            if (_plants.NameOfThisPlant == _inventory.NameOfCarrots)
            {
                _inventory.amountOfCarrotsPlants += _addRemove.AmountToChange;
                _inventory.money -= _addRemove.AmountToChange * _plants.CostOfThisPlant;
                _carrotsPlantsChange?.Invoke();
            }
            else if (_plants.NameOfThisPlant == _inventory.NameOfWheat)
            {
                _inventory.amountOfWheatPlants += _addRemove.AmountToChange;
                _inventory.money -= _addRemove.AmountToChange * _plants.CostOfThisPlant;
                _wheatPlantsChange?.Invoke();
            }
        }
    }

    public void SellPlants()
    {
        if (_plants.NameOfThisPlant == _inventory.NameOfCarrots)
        {
            if (_inventory.amountOfCarrotsPlants >= _addRemove.AmountToChange)
            {
                _inventory.amountOfCarrotsPlants -= _addRemove.AmountToChange;
                _inventory.money += _addRemove.AmountToChange * _plants.PlantSellPrice;
                _carrotsPlantsChange?.Invoke();
            }
        }
        if (_plants.NameOfThisPlant == _inventory.NameOfWheat)
        {
            if (_inventory.amountOfWheatPlants >= _addRemove.AmountToChange)
            {
                _inventory.amountOfWheatPlants -= _addRemove.AmountToChange;
                _inventory.money += _addRemove.AmountToChange * _plants.PlantSellPrice;
                _wheatPlantsChange?.Invoke();
            }
        }
    }
    public void BuySeeds()
    {
        if (_inventory.money >= _addRemove.AmountToChange * _plants.CostOfThisSeed)
        {
            if (_plants.NameOfThisSeed == _inventory.NameOfCarrots)
            {
                _inventory.amountOfCarrotsSeeds += _addRemove.AmountToChange;
                _inventory.money -= _addRemove.AmountToChange * _plants.CostOfThisSeed;
                _carrotsSeedsChange?.Invoke();
            }
            else if (_plants.NameOfThisSeed == _inventory.NameOfWheat)
            {
                _inventory.amountOfWheatSeeds += _addRemove.AmountToChange;
                _inventory.money -= _addRemove.AmountToChange * _plants.CostOfThisSeed;
                _wheatSeedsChange?.Invoke();
            }
        }
    }

    public void SellSeeds()
    {
        if (_plants.NameOfThisSeed == _inventory.NameOfCarrots)
        {
            if (_inventory.amountOfCarrotsSeeds >= _addRemove.AmountToChange)
            {
                _inventory.amountOfCarrotsSeeds -= _addRemove.AmountToChange;
                _inventory.money += _addRemove.AmountToChange * _plants.SeedSellPrice;
                _carrotsSeedsChange?.Invoke();
            }
        }
        if (_plants.NameOfThisSeed == _inventory.NameOfWheat)
        {
            if (_inventory.amountOfWheatSeeds >= _addRemove.AmountToChange)
            {
                _inventory.amountOfWheatSeeds -= _addRemove.AmountToChange;
                _inventory.money += _addRemove.AmountToChange * _plants.CostOfThisSeed;
                _wheatSeedsChange?.Invoke();
            }
        }
    }
}