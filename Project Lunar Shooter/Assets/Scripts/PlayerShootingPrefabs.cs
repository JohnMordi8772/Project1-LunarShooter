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
                    //Instantiate(lightAttack, transform.position, lightAttack.transform.rotation);
                    Instantiate(lightAttack, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), lightAttack.transform.rotation);
                    TurnManager.actionPoints--;
                }
            if (Input.GetKeyDown(KeyCode.W) && TurnManager.actionPoints > 0)
                {
                    //Instantiate(mediumAttack, transform.position, mediumAttack.transform.rotation);
                    Instantiate(mediumAttack, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), mediumAttack.transform.rotation);
                    TurnManager.actionPoints -= 2;
                }
            if (Input.GetKeyDown(KeyCode.E) && TurnManager.actionPoints > 0)
                {
                    //Instantiate(heavyAttack, transform.position, heavyAttack.transform.rotation);
                    Instantiate(heavyAttack, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), heavyAttack.transform.rotation);
                    TurnManager.actionPoints -= 3;
                }
        }
       
    }
}

