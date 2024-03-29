using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Plants : MonoBehaviour
{
    [SerializeField] protected Inventory _inventory;
    [SerializeField] protected PlantScriptable Scriptable;
    public int SeedSellPrice;
    public int CostOfThisSeed;
    public string NameOfThisSeed;
    public int PlantSellPrice;
    public int CostOfThisPlant;
    public string NameOfThisPlant;
}
