using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastPlayer : MonoBehaviour
{// this is my raycast. It's gonna detect items that the player is facing to help interact.
    [SerializeField]
    private float distance = 2;

    [SerializeField]
    private Text interactText;

    [SerializeField]
    private string interactButtonString;

    private Transform cubeCollisionTransform;

    private Iinteractable interactableInstance;
    private ICollectable collectableInstance;

    private Vector3 center;
    private BoxCollider collider;
    RaycastHit hit;
    Ray playerSight;
    private float inputButtonFloat;
    
   

    private void Start()
    {
        collider = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        center = collider.bounds.center;
        UpdatePlayerSight();
        CheckForCollide();
        UpdateButtonInput();
    }

    private void UpdateButtonInput()
    {
        inputButtonFloat = Input.GetAxis(interactButtonString);
    }

    private void UpdatePlayerSight()
    {
        playerSight = new Ray(this.transform.position, this.transform.forward);//might have to do vector3.forward
    }

    private void CheckForCollide()
    {
        if (Physics.Raycast(playerSight, out hit, distance))//this occurs if the ray hits something...
        {
            
            interactableInstance = hit.collider.gameObject.transform.parent.GetComponent<Iinteractable>();
            Debug.Log("I'm looking at " + interactableInstance.ToString());

            if (interactableInstance != null && interactableInstance.CanInteract())
            {
                interactableInstance.HighlightObjectText();

                if(inputButtonFloat > 0)//checks to see if you push the button
                {
                    interactableInstance.Interact();
                }
            }
        }
        else
        {
            interactText.gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)//this checks for the player getting collectables
    {
        collectableInstance = collision.transform.GetComponent<ICollectable>();//sets the collectable item
        if(collectableInstance != null)
        {
            collectableInstance.GetItem();
        }
    }
}

