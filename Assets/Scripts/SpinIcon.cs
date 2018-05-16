using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinIcon : MonoBehaviour {

    float speed = 100;
	
    private void FixedUpdate()
    {
        Spin();
    }

    private void Spin()
    {
        transform.Rotate(Vector3.up, speed* 2 * Time.deltaTime);
         
    }
}
