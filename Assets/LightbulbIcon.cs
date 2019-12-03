using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightbulbIcon : MonoBehaviour
{
    private Image image;

    private void Start()
    {
        image = GetComponentInChildren<Image>();
    }

    public void SetIcon(bool iconState)
    {
        if (iconState == true)
            image.enabled = true;
        else if (iconState == false)
            image.enabled = false;
    }

}
