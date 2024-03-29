using System.Collections;
using UnityEngine;

public class Field : Interactable
{
    [SerializeField] private GameObject _inventoryObject;
    public bool IsEmpty = true;
    public float TimeToGrow;
    [SerializeField] private GrowPlant _grownPlant;
    private GameObject _seedObject;
    private GameObject _growPlantObject;

    public override void Clicked()
    {
        if (IsEmpty)
        {
            _inventoryObject.SetActive(true);
        }
        else
        {
            _grownPlant = _growPlantObject.gameObject.GetComponent<GrowPlant>();
            _grownPlant.PlantAsGrown();
            Destroy(_growPlantObject);
            IsEmpty = true;
        }
    }

    public void StartGrowing(GameObject _seedGrowing, GameObject growPlant)
    {
        StartCoroutine(Growing(_seedGrowing, growPlant));
    }

    private IEnumerator Growing(GameObject _seedGrowing, GameObject _growPlant)
    {
        _seedObject = Instantiate(_seedGrowing, transform.position, transform.rotation);
        yield return new WaitForSecondsRealtime(TimeToGrow);
        Destroy(_seedObject);
        _growPlantObject = Instantiate(_growPlant, transform.position, transform.rotation);
    }
}
