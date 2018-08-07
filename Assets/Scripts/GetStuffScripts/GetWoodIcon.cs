using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetWoodIcon : MonoBehaviour, ICollectable
{
    private Text interactableText;

    private void Awake()
    {
        interactableText = GameObject.FindGameObjectWithTag("Int").GetComponent<Text>();
    }

    public void GetItem()
    {
        //deactivate
        //play item sound
        //destroy item
        //StartCoroutine(AnimateCollectableText());
        this.gameObject.SetActive(false);
        Inventory.wood += 10;
        //ADD animation of text informing inventory changes
        Debug.Log(Inventory.playerInventory.ToString());
    }

    //IEnumerator AnimateCollectableText()
    //{
    //    interactableText.CrossFadeAlpha(0, .2f, true);
    //    interactableText.text = "+ 10 Wood";
    //    interactableText.CrossFadeAlpha(100, 3, true);//see if this works
    //    yield return new WaitForSeconds(3);
    //}
}
