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

    private Transform cubeCollisionTransform;
    private Iinteractable interactableInstance;
    private Vector3 center;
    private BoxCollider collider;
    RaycastHit hit;
    Ray playerSight;

    private void Start()
    {
        collider = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        center = collider.bounds.center;
        UpdatePlayerSight();
        CheckForCollide();
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

            if (interactableInstance != null)
            {
                interactableInstance.HighlightObjectText();
            }
        }
        else
        {
            interactText.gameObject.SetActive(false);
        }
    }
}

