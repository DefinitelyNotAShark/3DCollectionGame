using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBunnyColor : MonoBehaviour {

    private Color bunnyColor;

    [SerializeField]
    private GameObject playerPrefab;

    private MeshRenderer[] renderers;


    // Use this for initialization
    void Start()
    {
        SetColor();
    }

    private void SetColor()
    {
        renderers = gameObject.GetComponentsInChildren<MeshRenderer>();
        for (int i = 0; i < renderers.Length; i++)
        {
            renderers[i].material.color = ColorPickerButtonManager.realBunnyColor;//lets hope this works!
        }
    }
}
