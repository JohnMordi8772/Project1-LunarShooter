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
            Instantiate(lightAttack, transform.position, lightAttack.transform.rotation);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(mediumAttack, transform.position, mediumAttack.transform.rotation);
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(heavyAttack, transform.position, heavyAttack.transform.rotation);
        }
    }
}
