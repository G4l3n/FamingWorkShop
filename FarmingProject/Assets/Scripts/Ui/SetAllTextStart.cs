using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetAllTextStart : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _moneyText;
    [SerializeField] private TextMeshProUGUI _carrotsPlantsText;
    [SerializeField] private TextMeshProUGUI _carrotsSeedsText;
    [SerializeField] private TextMeshProUGUI _wheatPlantsText;
    [SerializeField] private TextMeshProUGUI _wheatSeedsText;
    [SerializeField] private Inventory _inventory;

    // Start is called before the first frame update
    void Start()
    {
        _moneyText.SetText(_inventory.money.ToString() + " $");
        _carrotsPlantsText.SetText(_inventory.amountOfCarrotsPlants.ToString());
        _carrotsSeedsText.SetText(_inventory.amountOfCarrotsSeeds.ToString());
        _wheatPlantsText.SetText(_inventory.amountOfWheatPlants.ToString());
        _wheatSeedsText.SetText(_inventory.amountOfWheatSeeds.ToString());
    }
}
