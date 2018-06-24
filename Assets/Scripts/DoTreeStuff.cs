using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoTreeStuff : MonoBehaviour, Iinteractable
{
    private Color startColor;

    [SerializeField]
    private Color highlightColor;


    private Text interactableText;

    private void Awake()
    {
        interactableText = GameObject.FindGameObjectWithTag("Int").GetComponent<Text>();
    }

    //private void Start()
    //{
    //    interactableText.gameObject.SetActive(false);
    //}

    public void HighlightObjectText()//only public because has to be for interface
    {
        interactableText.gameObject.SetActive(true);
        interactableText.text = "cut down tree";
    }

    public void StopText()
    {
        Debug.Log("Stop text was called");
        interactableText.gameObject.SetActive(false);
        interactableText.text = "";
    }

    public void Interact()
    {

    }
}
