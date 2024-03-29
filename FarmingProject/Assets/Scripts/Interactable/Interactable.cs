using UnityEngine;
using UnityEngine.Events;

public abstract class Interactable : MonoBehaviour
{
    public UnityEvent IsClicked;
    public abstract void Clicked();
}
