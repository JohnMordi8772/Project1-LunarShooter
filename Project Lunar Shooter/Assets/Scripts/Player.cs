using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 100.0f;
    private float xUpperRange = 11;
    private float xLowerRange = -1;
    private float xLowerRange2 = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * horizontalInput);

        //keep player in bounds
        if (transform.position.x < -xLowerRange)
            if (transform.position.x < xLowerRange2)
            {
                transform.position = new Vector3(-xLowerRange, transform.position.y, transform.position.z);
                transform.position = new Vector3(xLowerRange2, transform.position.y, transform.position.z);
            }
        if (transform.position.x > xUpperRange)
        {
            transform.position = new Vector3(xUpperRange, transform.position.y, transform.position.z);
        }
    }
}
