/*Author: John Mordi and Josh Bumbalough
Assignment: Project Lunar Shooter
Description: When the enemy's and projectiles hit the end of the map*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 15;
    public float health;
    public float dmg;
    public AudioSource enemyAudio;
    public AudioClip explosionSound;
    public ParticleSystem explosionParticle;

    // Start is called before the first frame update
    void Start()
    {
        enemyAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.z > topBound)//if projectile doesn't hit an enemy, then is destroyed out of bounds
        {
            Destroy(gameObject);
        }
        if (transform.position.z <= 0)//if enemy reaches player row, then player loses life and enemy is destroyed
        {
            enemyAudio.PlayOneShot(explosionSound, 1.0f);
            explosionParticle.Play();
            Destroy(gameObject);
            EnemySpawn.enemiesKilled++;
            WinLossManager.lives -= dmg;
        }
    }
}
