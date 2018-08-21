using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookPlayer : MonoBehaviour
{
    [SerializeField]
    private float mouseSensitivity = 100;

    [SerializeField]
    private float clampAngle = 80;

    private float lookX = 0;
    private float lookY = 0;

    private float mouseX;
    private float mouseY;

    private Vector3 rotation;


    private void Start()
    {
        rotation = transform.localRotation.eulerAngles;
        lookX = rotation.x;
        lookY = rotation.y;
    }

    private void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        lookX += mouseX * mouseSensitivity * Time.deltaTime;
        lookY += mouseY * mouseSensitivity * Time.deltaTime;

        lookX = Mathf.Clamp(lookX, -clampAngle, clampAngle);

        Quaternion locRotation = Quaternion.Euler(rotation.x, rotation.y, 0);

        transform.rotation = locRotation;        
    }
}

