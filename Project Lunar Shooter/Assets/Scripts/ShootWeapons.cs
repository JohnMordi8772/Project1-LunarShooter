using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWeapons : MonoBehaviour
{
    public GameObject Beam;
    public GameObject Pistol;
    public GameObject Laser;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(Beam, transform.position, Beam.transform.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(Pistol, transform.position, Pistol.transform.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(Laser, transform.position, Laser.transform.rotation);
        }

    }
}
