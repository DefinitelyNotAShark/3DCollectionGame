using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public static List<string> playerInventory;
	// Use this for initialization
	void Start ()
    {
        playerInventory = new List<string>();
	}
}
