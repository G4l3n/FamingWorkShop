using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName ="ScriptableObjects/Plants")]
public class PlantScriptable : ScriptableObject
{
    [field: SerializeField]
    public string Name { get; private set; }
    [field: SerializeField]
    public int BuySeedCost { get; private set; }
    [field: SerializeField]
    public int SellSeedPrice { get; private set; }
    [field: SerializeField]
    public int BuyPlantCost { get; private set; }
    [field: SerializeField]
    public int SellPlantPrice { get; private set; }
    [field: SerializeField]
    public int AmountOfPlantArvested { get; private set; }
}
