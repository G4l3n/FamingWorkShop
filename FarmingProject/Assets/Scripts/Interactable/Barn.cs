using UnityEngine;

public class Barn : Interactable
{
    [SerializeField] private GameObject _canvasBarn;
    [SerializeField] private Inventory _inventory;

    public override void Clicked()
    {
        _canvasBarn.SetActive(true);
    }
}
