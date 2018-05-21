using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    private float horizontal;
    private float vertical;

    [SerializeField]
    private float speed = 10;

    private Vector3 position;
    private Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update ()
    {
        GetInput();
	}

    private void FixedUpdate()
    {
        Move();
    }

    void GetInput()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    void Move()
    {
        position = new Vector3(horizontal * Time.deltaTime * speed, 0, vertical * Time.deltaTime * speed);
        //rigidbody.AddForce(position);
        transform.Translate(position);
    }
}
