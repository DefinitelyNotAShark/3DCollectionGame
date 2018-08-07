using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoBarnDoorStuff : MonoBehaviour, Iinteractable
{
    private Text interactableText;

    private void Awake()
    {
        interactableText = GameObject.FindGameObjectWithTag("Int").GetComponent<Text>();
    }

    public void HighlightObjectText()
    {
        //Show inventory here
        foreach(string s in Inventory.playerInventory)
        {
            Debug.Log("Inventory: " + s);
        }

        interactableText.gameObject.SetActive(true);
        if (Inventory.playerInventory.Contains("key"))
            interactableText.text = "enter barn";

        else
            interactableText.text = "locked";
    }

    public void Interact()
    {
        throw new System.NotImplementedException();
    }

    public void StopText()
    {
        throw new System.NotImplementedException();
    }
}
