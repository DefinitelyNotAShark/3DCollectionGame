using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodUI : MonoBehaviour
{
    private Text woodText;

	// Use this for initialization
	void Start ()
    {
        woodText = GetComponent<Text>();
        this.gameObject.SetActive(false);       
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        woodText.text = "Wood: " + Inventory.wood;
	}
}
