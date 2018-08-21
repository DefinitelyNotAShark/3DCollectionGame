using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoBucketStuff : MonoBehaviour, Iinteractable
{
    private Text interactableText;

    private void Awake()
    {
        interactableText = GameObject.FindGameObjectWithTag("Int").GetComponent<Text>();
    }

    public void HighlightObjectText()
    {
        interactableText.gameObject.SetActive(true);
        interactableText.text = "Take bucket";
    }

    public void Interact()
    {
        Inventory.playerInventory.Add("bucket");
        this.gameObject.SetActive(false);
    }

    public void StopText()
    {
        interactableText.gameObject.SetActive(false);
        interactableText.text = "";
    }

    public bool CanInteract()//only if on bucket quest?
    {
        return true;
    }
}
