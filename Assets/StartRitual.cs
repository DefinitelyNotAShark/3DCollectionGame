using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class StartRitual : MonoBehaviour
{
    [SerializeField]
    private CameraShake shake;

    [SerializeField]
    private GameObject DemonBunny;

    public void TriggerRitual()
    {
        StartCoroutine(RitualStart());
    }

    IEnumerator RitualStart()
    {
        shake.shakeDuration = 1;
        yield return new WaitForSeconds(.5f);
        Instantiate(DemonBunny);
    }
}
