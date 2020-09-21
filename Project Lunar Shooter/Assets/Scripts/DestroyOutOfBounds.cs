/*Author: George Tang
Assignment: Project Lunar Shooter
Description: When the enemy's and projects hit the end of the map*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 15;
    public float health;
    public float dmg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z <= 0)
        {
            Destroy(gameObject);
            WinLossManager.lives -= dmg;
        }
    }
}
