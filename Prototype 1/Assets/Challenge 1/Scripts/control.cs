using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    private float speed = 15.0f;
    private float rotationSpeed = 35.0f;
    private float horizontalInput;
    private float up_Down;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        horizontalInput = Input.GetAxis("Horizontal");
        up_Down = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime );

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime * up_Down);
    }
}
