/*Author: Levi Wyant, John Mordi, Pyrus Djoi, George Tang, and Josh Bumbalough
//Assignment: Project Lunar Shooter
//Description: Spawms enemies in Row 12 before moving them on next turn.*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{//spawn will be fixed in the coming weeks to be less intensive and have a more defined rate

    public GameObject[] enemyArray;
    float randx;
    Vector3 whereToSpawn;
    /* The spawn rate needs to be based on a bool of if player turn or not*/
//public float spawnRate = 2f; 
float nextSpawn = 0.0f;
    private float spawnCount;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!TurnManager.isPlayerTurn)
        {
            if (spawnCount <= 3)
            {


                int index = Random.Range(0, 3);
                // nextSpawn = Time.time + spawnRate;   //BASED ON IF PLAYER TURN OR NOT
                randx = Random.Range(1, 12);
                //make is to set spawn position of z would be 11


                whereToSpawn = new Vector3(randx, 1, 11);
                Instantiate(enemyArray[index], whereToSpawn, Quaternion.identity);

                spawnCount++;
            }

        }
        else
        {
            spawnCount = 0;
        }
    }
}
