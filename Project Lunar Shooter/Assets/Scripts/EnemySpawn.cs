﻿/*Author: Levi Wyant, John Mordi, Pyrus Djoi, George Tang, and Josh Bumbalough
//Assignment: Project Lunar Shooter
//Description: Spawms enemies in Row 12 before moving them on next turn.*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemySpawn : MonoBehaviour
{//spawn will be fixed in the coming weeks to be less intensive and have a more defined rate

    public int waveNumber;
    public static int enemiesKilled;
    public GameObject[] enemyArray;
    float randx;
    Vector3 whereToSpawn;
    /* The spawn rate needs to be based on a bool of if player turn or not*/
    //public float spawnRate = 2f; 
    float nextSpawn = 0.0f;
    public float spawnCount;
    public Text wave;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if (!Tutorial.tutorialOver)
        {
            waveNumber = 0;
            spawnCount = 11;
            enemiesKilled = 0;
        }
        else
        {
            waveNumber = 0;
            spawnCount = 0;
            enemiesKilled = 0;
        }
        wave.text = "Wave: " + waveNumber;
    }

    // Update is called once per frame
    void Update()
    {
        if (Tutorial.tutorialOver)
        {
            if (waveNumber < 3 || enemiesKilled != spawnCount)
            {
                if (enemiesKilled >= spawnCount)
                {
                    TurnManager.isPlayerTurn = false;
                    NextWave();
                    wave.text = "Wave: " + waveNumber;
                }
            }
            else
            {
                if (WinLossManager.lives > 0)
                {
                    WinLossManager.gameover = true;
                    WinLossManager.win = true;
                }
            }

            
        }

    }

    private void SpawnEnemy()
    {
        /*This index will be how we "randomly" choose a heavy light, or medium type. 
        //      * 0 = light  type
        //      * 1 = medium type
        //      * 2 = heavy  type
        //      */
        int index = Random.Range(0, 3);
        randx = Random.Range(2, 11);

        //where to spawn row changed to = 12 as that is the furthurest back the enemies can spawn
        whereToSpawn = new Vector3(randx, 1, 12);

        //enemyArray picks which enemy to spawn, Where to spawn designates location of spawn
        //Quaternion.identity makes sure the model does not rotate. When we spawn in enemies or if they move. 
        Instantiate(enemyArray[index], whereToSpawn, Quaternion.Euler(0,180,0));
    }

    private void StartWave()
    {
        waveNumber = 1;
        spawnCount = 20;
        enemiesKilled = 0;
        for(int i = 0; i < spawnCount; i++)
        {
            SpawnEnemy();
        }
    }

    private void NextWave()
    {
        waveNumber++;
        spawnCount += 10;
        enemiesKilled = 0;
        for(int i = 0; i < spawnCount; i++)
        {
            SpawnEnemy();
        }
        
    }
}
