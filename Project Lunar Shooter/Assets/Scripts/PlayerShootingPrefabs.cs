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

    private AudioSource playerAudio;
    public AudioClip pistolSound;
    public AudioClip laserSound;
    public AudioClip beamSound;

    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if(TurnManager.isPlayerTurn)
        {
            if (Input.GetKeyDown(KeyCode.Q) && TurnManager.actionPoints >=1)
                {
                    //does 3 dmg to one enemy, so it has a low cost. also, the projectile always fires one space in front of the player so that out of bounds functions properly.
                    Instantiate(lightAttack, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), lightAttack.transform.rotation);
                    TurnManager.actionPoints--;
                    playerAudio.PlayOneShot(pistolSound, 1.0f);
                }
            if (Input.GetKeyDown(KeyCode.W) && TurnManager.actionPoints >= 2)
                {
                    //does 2 dmg to one enemy, so it has a higher cost.
                    Instantiate(mediumAttack, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), mediumAttack.transform.rotation);
                    Instantiate(mediumAttack, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z + 1), mediumAttack.transform.rotation);
                    Instantiate(mediumAttack, new Vector3(transform.position.x - 1, transform.position.y, transform.position.z + 1), mediumAttack.transform.rotation);
                    TurnManager.actionPoints -= 2;
                    playerAudio.PlayOneShot(laserSound, 1.0f);
                }
            if (Input.GetKeyDown(KeyCode.E) && TurnManager.actionPoints >= 3)
                {
                    //does one dmg to all enemies in column, so it costs the most
                    Instantiate(heavyAttack, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), heavyAttack.transform.rotation);
                    TurnManager.actionPoints -= 3;
                    playerAudio.PlayOneShot(beamSound, 1.0f);
                }
        }
       
    }
}

