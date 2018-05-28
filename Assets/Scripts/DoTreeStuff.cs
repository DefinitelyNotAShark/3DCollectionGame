using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoTreeStuff : MonoBehaviour, Iinteractable
{
    Color startColor;

	void Update ()
    {
	}

    public void HighlightObject()//only public because has to be for interface
    {
        foreach (Transform child in transform)//get the objects in the tree
        {
            if (child.GetComponent<MeshRenderer>() != null)//if there is a renderer...
            {
                startColor = child.GetComponent<MeshRenderer>().material.color;//get the color it started with
                child.GetComponent<MeshRenderer>().material.color = Color.blue;//change the color to the material color
            }
        }
    }

    public void UnHighlightObject()
    {
        foreach (Transform child in transform)//get the objects in the tree
        {
            if (child.GetComponent<MeshRenderer>() != null)//if there is a renderer...
            {
                child.GetComponent<MeshRenderer>().material.color = startColor;//change the color to the material color
            }
        }
    }

    public void Interact()
    {

    }
}
