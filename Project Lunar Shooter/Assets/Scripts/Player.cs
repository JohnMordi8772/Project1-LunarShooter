using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 100.0f;
    private float xUpperRange = 11;
    private float xLowerRange = 1;


    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal"); 
        
        if(TurnManager.isPlayerTurn && TurnManager.actionPoints > 0)
        {
            if(Input.GetButtonDown("Horizontal"))
            {
                transform.Translate(Vector3.right * horizontalInput);
                TurnManager.actionPoints--;
            }
        }

        //keep player in bounds
        if (transform.position.x < xLowerRange)
        { 
            transform.position = new Vector3(xLowerRange, transform.position.y, transform.position.z);
            TurnManager.actionPoints++;
        }
        if (transform.position.x > xUpperRange)
        {
            transform.position = new Vector3(xUpperRange, transform.position.y, transform.position.z);
            TurnManager.actionPoints++;
        }
    }
}
