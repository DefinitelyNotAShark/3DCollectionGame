using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    private string movementAxisName;
    private string turnAxisName;

    private float movementAxisValue;
    private float turnAxisValue;

    [SerializeField]
    private float speed = 10;

    [SerializeField]
    private float turnSpeed = 100;

    private Vector3 position;
    private Rigidbody rigidbody;

    private void Start()
    {
        movementAxisName = "Vertical";
        turnAxisName = "Horizontal";
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        GetInput();
    }

    private void FixedUpdate()
    {
        Move();
        Turn();
    }

    void GetInput()
    {
        movementAxisValue = Input.GetAxis(movementAxisName);//stores my input for each update
        turnAxisValue = Input.GetAxis(turnAxisName);
    }

    void Move()
    {//DEBUG check if transform.forward actually works
        Vector3 movement = transform.forward * movementAxisValue * speed * Time.deltaTime;//sets a vector3 to forward times input value
        rigidbody.MovePosition(rigidbody.position + movement);//moves my rigidbody the vector3
    }

    void Turn()
    {
        float turn = turnAxisValue * turnSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);//this creates a q for the turning
        rigidbody.MoveRotation(rigidbody.rotation * turnRotation);//this actually turns it

    }
}
