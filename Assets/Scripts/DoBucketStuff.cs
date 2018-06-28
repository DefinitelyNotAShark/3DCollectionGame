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
        this.gameObject.SetActive(false);
        Inventory.playerInventory.Add("bucket");
        Debug.Log(Inventory.playerInventory.ToString());
    }

    public void StopText()
    {
        interactableText.gameObject.SetActive(false);
        interactableText.text = "";
    }
}
