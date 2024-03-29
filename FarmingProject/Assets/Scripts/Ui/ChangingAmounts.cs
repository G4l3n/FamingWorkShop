using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangingAmounts : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textAmount;
    [SerializeField] private Inventory _inventory;

    public void OnChangingCarrotsSeeds()
    {
        _textAmount.SetText(_inventory.amountOfCarrotsSeeds.ToString());
    }
    public void OnChangingCarrotsPlants()
    {
        _textAmount.SetText(_inventory.amountOfCarrotsPlants.ToString());
    }
    public void OnChangingWheatSeeds()
    {
        _textAmount.SetText(_inventory.amountOfWheatSeeds.ToString());
    }
    public void OnChangingWheatPlants()
    {
        _textAmount.SetText(_inventory.amountOfWheatPlants.ToString());
    }
    public void OnChangingMoney()
    {
        _textAmount.SetText(_inventory.money.ToString() + " $");
    }
}
