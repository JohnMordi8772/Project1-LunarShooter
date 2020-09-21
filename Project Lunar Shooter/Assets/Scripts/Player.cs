/*Author: Josh Bumbalough, John Mordi
//Assignment: Project Lunar Shooter
//Description: Manages the controls of the player(moving).
*/
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
        horizontalInput = Input.GetAxisRaw("Horizontal");//either 1 or -1
        
        if(TurnManager.isPlayerTurn && TurnManager.actionPoints > 0)//prevents player from moving on enemy turn and if the player has no points left
        {
            if(Input.GetButtonDown("Horizontal"))
            {
                transform.Translate(Vector3.right * horizontalInput);
                TurnManager.actionPoints--;//movement costs an action point
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
