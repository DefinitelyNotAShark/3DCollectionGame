using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableThis : MonoBehaviour
{
    [SerializeField]
    private DialogueDatabase database;

    public void Disable()
    {
        int variable =  DialogueLua.GetVariable("Wood").AsInt;
        if(variable >= 9)//doesn't reach 10 until after disabled //mark quest as success here
        {
            Debug.Log("Ya did it!");
        }

        this.gameObject.SetActive(false);
    }
}
