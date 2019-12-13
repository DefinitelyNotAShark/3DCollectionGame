using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointFinder : MonoBehaviour
{
    [SerializeField]
    private GameObject wayPoint;

    [SerializeField]
    private float speed;

    [SerializeField]
    private GameObject center;

    private bool goToPoint;

    private void Update()
    {
        if (goToPoint == true)
        { 
            float distance = Vector3.Distance(this.transform.position, wayPoint.transform.position);//check dista

            if (distance > 2f)
            {
                transform.position = Vector3.MoveTowards(this.transform.position, wayPoint.transform.position, speed * Time.deltaTime);
                transform.LookAt(wayPoint.transform.position);
            }
            else
            {
                transform.LookAt(center.transform.position);
            }
        }
    }

    public void DoThing()
    {
        goToPoint = true;
    }

}
