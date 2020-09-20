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
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(lightAttack, transform.position, lightAttack.transform.rotation);
            //Instantiate(lightAttack, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), lightAttack.transform.rotation);
            // causes player to shoot two items ^
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(mediumAttack, transform.position, mediumAttack.transform.rotation);
            //Instantiate(mediumAttack, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), mediumAttack.transform.rotation);
            // causes player to shoot two items ^
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(heavyAttack, transform.position, heavyAttack.transform.rotation);
            //Instantiate(heavyAttack, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), heavyAttack.transform.rotation);
            // causes player to shoot two items ^
        }
    }
}

