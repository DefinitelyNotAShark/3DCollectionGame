using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoIconStuff : MonoBehaviour, Iinteractable
{
    private Text interactableText;

    private void Awake()
    {
        interactableText = GameObject.FindGameObjectWithTag("Int").GetComponent<Text>();
    }

    public void HighlightObjectText()
    {
        interactableText.gameObject.SetActive(true);
        interactableText.text = "Pick up wood";
    }

    public void Interact()
    {
        Inventory.wood += 10;
        //ADD animation of text informing inventory changes
        Debug.Log(Inventory.playerInventory.ToString());
        this.gameObject.SetActive(false);
    }

    public void StopText()
    {
        interactableText.gameObject.SetActive(false);
        interactableText.text = "";
    }
}
