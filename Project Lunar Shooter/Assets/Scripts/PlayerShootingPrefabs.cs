/*Author: Josh Bumbalough, George Tang
//Assignment: Project Lunar Shooter
//Description: Allows player to shoot projectiles at the cost of action points.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingPrefabs : MonoBehaviour
{
    // Start is called before the first frame update
    
    // beam
    public GameObject lightAttack;
    // pistol
    public GameObject mediumAttack;
    // laser
    public GameObject heavyAttack;

    // Update is called once per frame
    void Update()
    {
        if(TurnManager.isPlayerTurn)
        {
            if (Input.GetKeyDown(KeyCode.Q) && TurnManager.actionPoints > 0)
                {
                    //does one dmg to one enemy, so it has a low cost. also, the projectile always fires one space in front of the player so that out of bounds functions properly.
                    Instantiate(lightAttack, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), lightAttack.transform.rotation);
                    TurnManager.actionPoints--;
                }
            if (Input.GetKeyDown(KeyCode.W) && TurnManager.actionPoints > 0)
                {
                    //does 3 dmg to one enemy, so it has a higher cost.
                    Instantiate(mediumAttack, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), mediumAttack.transform.rotation);
                    TurnManager.actionPoints -= 2;
                }
            if (Input.GetKeyDown(KeyCode.E) && TurnManager.actionPoints > 0)
                {
                    //does one dmg to all enemies in column, so it costs the most
                    Instantiate(heavyAttack, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), heavyAttack.transform.rotation);
                    TurnManager.actionPoints -= 3;
                }
        }
       
    }
}

