using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoNPCStuff : MonoBehaviour, Iinteractable
{
    [SerializeField]
    private string[] npcText;

    private Text npcDialogueText;
    private Text interactText;

    public void HighlightObjectText()
    {
        interactText.gameObject.SetActive(true);
        interactText.text = "Talk";
    }

    public void Interact()
    {
        interactText.text = "";
        interactText.gameObject.SetActive(false);
        for(int i = 0; i < npcText.Length; i++)
        {
            npcDialogueText.text = npcText[i];
            //set bouncing ball animation to active true
            //wait until button pressed (bool + update)?
            //on button pressed, erase all text and set animation active false and panel
        }
    }

    public void StopText()
    {
        interactText.text = "";
        interactText.gameObject.SetActive(false);
    }
    
    void Update()
    {

    }
}
