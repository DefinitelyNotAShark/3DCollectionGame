using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoFenceStuff : MonoBehaviour, Iinteractable
{
    private Text interactableText;
    private bool openedGate;

    public bool CanInteract()
    {
        return true;
    }

    public void HighlightObjectText()
    {
        interactableText.gameObject.SetActive(true);
        interactableText.text = "Open Gate";
    }

    public void Interact()
    {
        if(GlobalVars.gotKey)
        {
            openedGate = true;
            //play an unlocking noise here
            interactableText.text = "Should be unlocking now";
            //Do Unlock();
        }
        else
        {
            interactableText.text = "Locked";
        }
    }

    public void StopText()
    {
        interactableText.gameObject.SetActive(false);
        interactableText.text = "";
    }

    // Use this for initialization
    void Awake ()
    {
        interactableText = GameObject.FindGameObjectWithTag("Int").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Start()
    {
        interactableText.gameObject.SetActive(false);
    }
}
