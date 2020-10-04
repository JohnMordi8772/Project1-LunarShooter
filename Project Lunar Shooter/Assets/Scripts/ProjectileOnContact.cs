/*Author: John Mordi
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
        other.gameObject.GetComponent<DestroyOutOfBounds>().explosionParticle.Play();
        other.gameObject.GetComponent<DestroyOutOfBounds>().health -= dmg;
        
        if (other.gameObject.GetComponent<DestroyOutOfBounds>().health <= 0)
        {
            
            //other.gameObject.GetComponent<DestroyOutOfBounds>().enemyAudio.PlayOneShot(FindObjectOfType<DestroyOutOfBounds>().explosionSound, 1.0f);
            Destroy(other.gameObject);
            Destroy(gameObject);
            EnemySpawn.enemiesKilled++;
        }
        else
        {
            Destroy(gameObject);
        }
        //Destroy(other.gameObject);
        //Destroy(gameObject);
    }
}
