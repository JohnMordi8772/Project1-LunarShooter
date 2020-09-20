using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 100.0f;
    private float xUpperRange = 11;
    private float xLowerRange = 0;

    // Update is called once per frame
    void Update()
    {
        // horizontal input from right and left arrow or A ad D keys
        horizontalInput = Input.GetAxisRaw("Horizontal");

        //transform horizontally with input
        if(Input.GetButtonDown("Horizontal"))
            transform.Translate(Vector3.right * horizontalInput);

        //keep player in bounds
        if (transform.position.x < -xLowerRange)
        {
            transform.position = new Vector3(-xLowerRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xUpperRange)
        {
            transform.position = new Vector3(xUpperRange, transform.position.y, transform.position.z);
        }
    }
}
