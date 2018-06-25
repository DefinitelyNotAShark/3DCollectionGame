﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoTreeStuff : MonoBehaviour, Iinteractable
{
    private Text interactableText;

    private void Awake()
    {
        interactableText = GameObject.FindGameObjectWithTag("Int").GetComponent<Text>();
    }

    private void Start()//this seems to work now. 
    {
        interactableText.gameObject.SetActive(false);
    }

    public void HighlightObjectText()//only public because has to be for interface
    {
        interactableText.gameObject.SetActive(true);
        interactableText.text = "cut down tree";
    }

    public void StopText()
    {
        interactableText.gameObject.SetActive(false);
        interactableText.text = "";
    }

    public void Interact()
    {
        //play tree cutting down sound.
        //replace tree with spinning icon
        //make icon collectable
        //make collectable icon increase wood value in UI inventory
        this.gameObject.SetActive(false);
        
        //REMEMBER wait until sound is done to destroy. Probably want to make it invisible first!!!
       // Destroy(gameObject);//do this last so the script doesn't cut out early
    }
}
