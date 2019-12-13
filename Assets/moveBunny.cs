using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//bob script gotten from http://www.donovankeith.com/2016/05/making-objects-float-up-down-in-unity/
public class moveBunny : MonoBehaviour
{
    [SerializeField]
    private float amplitude, frequency, rateOfFog;

    private Vector3 posOffset = new Vector3();
    private Vector3 tempPos = new Vector3();

    [SerializeField]
    private ParticleSystem particles;//get the gameobject so it doesn't accidentally grab a different one that's a child of the first one.

    [SerializeField]
    private GameObject body;

    private bool fogCoroutineStarted = false;

    private void Start()
    {
        body.gameObject.SetActive(false);
        posOffset = transform.position;
        particles.Play();
    }

    void Update()
    {
        if (!particles.isEmitting)
        {
            if (!body.activeSelf)
                body.SetActive(true);

            if(!fogCoroutineStarted)
                StartCoroutine(MakeFog());

            Bob();
        }
    }

    private void Bob()
    {
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }

    private IEnumerator MakeFog()
    {
        fogCoroutineStarted = true;

        for(float i = 0; i <.03; i+= .001f)
        {
            RenderSettings.fogDensity = i;
            yield return new WaitForSeconds(rateOfFog);
        }
    }
}
