using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour
{
    private Color alphaColor;
    private Color panelColor;
    private float timeToFade = 2;

    private void Start()
    {
        panelColor = gameObject.GetComponent<Image>().color;//gets the current image color;

        alphaColor = gameObject.GetComponent<Image>().color;
        alphaColor.a = 0;
    }

    public void FadeOut()
    {
        gameObject.GetComponent<Image>().CrossFadeColor(alphaColor, timeToFade, false, true);
        StartCoroutine(WaitForFade());//this just sets it false after fade;;;
    }

    private IEnumerator WaitForFade()
    {
        yield return new WaitForSeconds(timeToFade);
        gameObject.SetActive(false);
        Debug.Log("coroutine done. Should be set active false now!!!");
        gameObject.GetComponent<Image>().color = panelColor;//resets color;;;
    }
}
