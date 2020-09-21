/*Author: John Mordi
//Assignment: Project Lunar Shooter
//Description: Makes the enemies move their designated speeds once on their turn.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public bool moved = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!TurnManager.isPlayerTurn)
        {
            if (!moved)
            {
                transform.Translate(new Vector3(0, 0, -1) * speed);//move down column with their own speeds specified in inspector
                moved = true;
            }
        }
        else
        {
            moved = false;
        }
    }
}
