using UnityEngine;

public class GrabbableItem : MonoBehaviour
{ 
    public LayerMask ItemLayer;
    public LayerMask FieldLayer;

    [SerializeField] private GameObject _seedToGrow;
    [SerializeField] private GameObject _growedPlant;
    [SerializeField] private Inventory _inventory;

    [HideInInspector] public bool IsGrab;
    [HideInInspector] public bool IsField;
    [HideInInspector] public GameObject _dragObject;
    private Vector3 pos;
    private Ray ray;
    private RaycastHit hit;
    private Field _field;
    private Seeds _seeds;

    void FixedUpdate()
    {
        Dragging();
    }

    /// <summary>
    /// make _dragObject to follow the mouse if IsGrab is true and destroy it if it's false
    /// </summary>
    private void Dragging()
    {
        if (IsGrab)
        {
            pos = Input.mousePosition;
            pos.z = 3f;
            _dragObject.transform.position = Camera.main.ScreenToWorldPoint(pos);
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            _seeds = _dragObject.GetComponent<Seeds>();
        }
        else
        {
            Destroy(_dragObject);
        }
    }

    /// <summary>
    /// check if there is an object with the tag interactable and the layer of layer mask FieldLayer
    /// </summary>
    public void Droping()
    {
        if (Physics.Raycast(ray, out hit, 200, ~ItemLayer))
        {
            //(FieldLayer == (FieldLayer | (1 << hit.transform.gameObject.layer))) verifie si le layer de l'object est égale au layer mask, peut donc contenir plusieurs layer
            if (hit.transform != null && hit.transform.CompareTag("Interactable") && (FieldLayer == (FieldLayer | (1 << hit.transform.gameObject.layer))))
            {
                _field = hit.transform.GetComponent<Field>();
                if (_field.IsEmpty && _seeds.AmountOfThisSeed > 0)
                {
                    _field.IsEmpty = !_field.IsEmpty;
                    _field.StartGrowing(_seedToGrow, _growedPlant);
                    _seeds.PlantedSeed();
                }
                else
                {
                    return;
                }

            }
        }
        else
        {
            return;
        }
    }
}
