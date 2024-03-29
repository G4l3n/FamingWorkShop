using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class MouseController : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;
    private Field _field;
    private Barn _barn;
    private GrabbableItem _gbItem;
    private Ray _ray;
    private RaycastHit _hit;

    public void OnClick(InputAction.CallbackContext value)
    {
        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (value.started)
        {
            return;
        }
        if (value.performed)
        {
            if (Physics.Raycast(_ray, out _hit, 200))
            {
                if (!EventSystem.current.IsPointerOverGameObject())
                {
                    if (_hit.collider != null && _hit.transform.CompareTag("Interactable"))
                    {
                        if (_hit.transform.gameObject.layer == 7)
                        {
                            _field = _hit.transform.gameObject?.GetComponent<Field>();
                            _field.IsClicked?.Invoke();
                        }
                        else if (_hit.transform.gameObject.layer == 8)
                        {
                            _barn = _hit.transform.gameObject?.GetComponent<Barn>();
                            _barn.IsClicked?.Invoke();
                        }

                    }
                    if (_hit.collider != null && _hit.collider.CompareTag("Plant"))
                    {
                        _gbItem = _hit.transform.gameObject.GetComponent<GrabbableItem>();
                        _gbItem._dragObject = Instantiate(_gbItem.gameObject, Input.mousePosition, _gbItem.gameObject.transform.rotation);
                        _gbItem.IsGrab = true;
                    }
                }
            }
        }
        if (value.canceled)
        {
            if (_gbItem != null)
            {
                _gbItem.Droping();
                _gbItem.IsGrab = false;
                _gbItem = null;
            }
        }
    }
}
