using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetNPCColor : MonoBehaviour {

    [SerializeField]
    private Color npcColor;

    [SerializeField]
    private Image bunnyAvatar;

    private MeshRenderer[] renderers;
    private DoNPCStuff doNPCStuff;

	// Use this for initialization
	void Start ()
    {
        renderers = GetComponentsInChildren<MeshRenderer>();//put all renderers in array
        for(int i = 0; i < renderers.Length; i++)//for each renderer
        {
            renderers[i].material.color = npcColor;//set it to npccolor
        }
        bunnyAvatar.color = npcColor;//this sets the color of the avatar we see
	}
}
