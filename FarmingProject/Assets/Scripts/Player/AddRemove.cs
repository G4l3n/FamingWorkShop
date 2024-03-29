using TMPro;
using UnityEngine;

public class AddRemove : MonoBehaviour
{
    public int AmountToChange = 1;
    [SerializeField] private TextMeshProUGUI _AmountText;

    public void Adding()
    {
        AmountToChange += 1;
        _AmountText.SetText(AmountToChange.ToString());
    }

    public void Removing()
    {
        AmountToChange -= 1;
        _AmountText.SetText(AmountToChange.ToString());
    }
}
