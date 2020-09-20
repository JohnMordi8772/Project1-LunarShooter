using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootPrefab : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lightAttack;
    public GameObject mediumAttack;
    public GameObject heavyAttack;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(lightAttack, new Vector3(transform.position.x, transform.position.y, transform.position.z+1), lightAttack.transform.rotation);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(mediumAttack, new Vector3(transform.position.x, transform.position.y, transform.position.z+1), mediumAttack.transform.rotation);
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(heavyAttack, new Vector3(transform.position.x, transform.position.y, transform.position.z+1), heavyAttack.transform.rotation);
        }
    }
}
