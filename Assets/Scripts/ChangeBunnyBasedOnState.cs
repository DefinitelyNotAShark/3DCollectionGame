using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBunnyBasedOnState : MonoBehaviour {
    //this class changes the bunny object based on the bunny state
    public enum PlayerState { idle, jumping, }
    public PlayerState State { private get; set; }//only this class can read state.

    [SerializeField]
    GameObject bunnyStill;

    [SerializeField]
    GameObject bunnyJump;


    // Update is called once per frame
    void Update()
    {
        checkState();
    }

    private void checkState()
    {
        if (State == PlayerState.idle)
        {
            bunnyStill.SetActive(true);
            bunnyJump.SetActive(false);
        }
        else if (State == PlayerState.jumping)
        {
            bunnyStill.SetActive(false);
            bunnyJump.SetActive(true);
        }
    }
}
