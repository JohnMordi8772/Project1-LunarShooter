﻿/*Author: John Mordi
//Assignment: Project Lunar Shooter
//Description: Applies dmg to enemies and destroys gameobjects on collisions
               and when enemy health reaches 0.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileOnContact : MonoBehaviour
{
    public float dmg;
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<DestroyOutOfBounds>().health -= dmg;
        if (other.gameObject.GetComponent<DestroyOutOfBounds>().health <= 0)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        //Destroy(other.gameObject);
        //Destroy(gameObject);
    }
}
