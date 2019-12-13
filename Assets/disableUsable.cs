
using PixelCrushers.DialogueSystem.Wrappers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableUsable : MonoBehaviour
{
    [SerializeField]
    private GameObject logs;

    [SerializeField]
    private ParticleSystem fire;
    
    public void Disable()
    {
        if (logs.gameObject.activeSelf == false)
            logs.gameObject.SetActive(true);

        fire.Play();
    }
}
