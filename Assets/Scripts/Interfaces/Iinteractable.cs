using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Iinteractable
{
    void HighlightObjectText();
    void StopText();
    void Interact();
    bool CanInteract();
}
