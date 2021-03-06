﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text tutorialText;
    public static bool tutorialOver = false;
    // Start is called before the first frame update
    void Start()
    {
        tutorialText.text = "";
        if (!tutorialOver)
            StartCoroutine(TutorialFunction());
    }

    IEnumerator TutorialFunction()
    {
        TurnManager.actionPoints = 100;

        tutorialText.text = "Welcome to Lunar Shooter! We hope you'll enjoy yourself while you play our game. Press SPACE to progress through the tutorial when you finish reading.";

        while (!Input.GetKeyDown(KeyCode.Space))
        {
            yield return null;
        }

        tutorialText.text = "We'll start with a tutorial to help you understand the game a little better. You'll get 100 action points for this, but will usually have 8.";

        while (!Input.GetKeyDown(KeyCode.Space))
        {
            yield return null;
        }

        tutorialText.text = "Press A to move left and D to move right.";

        while (!Input.GetKeyDown(KeyCode.A))
        {
             yield return null;
        }
        while (!Input.GetKeyDown(KeyCode.D))
        {
             yield return null;
        }

        tutorialText.text = "Good job! You might have noticed that Action Points has decreased by some. This is because everything you do has some kind of cost that must be payed." +
            " Movement/A and D cost 1 Action Point or AP. Although, movement isn't the only thing you can do.";

        while (!Input.GetKeyDown(KeyCode.Space))
        {
            yield return null;
        }

        tutorialText.text = "Press Q to fire a projectile that will deal three damage to the first enemy it hits. This will cost 1 AP.";

        Instantiate(FindObjectOfType<EnemySpawn>().enemyArray[0], new Vector3(6, 1, 12), Quaternion.Euler(0,180,0));

        while(!Input.GetKeyDown(KeyCode.Q))
        {
            yield return null;
        }

        yield return new WaitForSeconds(1);

        tutorialText.text = "Now, press W to fire projectiles in all adjacent columns that deal 1 damage each to the first enemy they hit. This will cost 2 AP.";

        Instantiate(FindObjectOfType<EnemySpawn>().enemyArray[0], new Vector3(5, 1, 12), Quaternion.Euler(0,180,0));
        Instantiate(FindObjectOfType<EnemySpawn>().enemyArray[0], new Vector3(6, 1, 12), Quaternion.Euler(0,180,0));
        Instantiate(FindObjectOfType<EnemySpawn>().enemyArray[0], new Vector3(7, 1, 12), Quaternion.Euler(0,180,0));

        while (!Input.GetKeyDown(KeyCode.W))
        {
            yield return null;
        }

        yield return new WaitForSeconds(1);

        tutorialText.text = "Finally, press E to fire a projectile that will pierce through all enemies in your current column dealing 1 damage to each enemy it hits. This will cost 3 AP.";

        Instantiate(FindObjectOfType<EnemySpawn>().enemyArray[0], new Vector3(6, 1, 12), Quaternion.Euler(0,180,0));
        Instantiate(FindObjectOfType<EnemySpawn>().enemyArray[0], new Vector3(6, 1, 11), Quaternion.Euler(0,180,0));
        Instantiate(FindObjectOfType<EnemySpawn>().enemyArray[0], new Vector3(6, 1, 10), Quaternion.Euler(0,180,0));
        Instantiate(FindObjectOfType<EnemySpawn>().enemyArray[0], new Vector3(6, 1, 9), Quaternion.Euler(0,180,0));
        Instantiate(FindObjectOfType<EnemySpawn>().enemyArray[0], new Vector3(6, 1, 8), Quaternion.Euler(0,180,0));
        Instantiate(FindObjectOfType<EnemySpawn>().enemyArray[0], new Vector3(6, 1, 7), Quaternion.Euler(0,180,0));
        Instantiate(FindObjectOfType<EnemySpawn>().enemyArray[0], new Vector3(6, 1, 6), Quaternion.Euler(0,180,0));

        while (!Input.GetKeyDown(KeyCode.E))
        {
            yield return null;
        }

        yield return new WaitForSeconds(1);

        tutorialText.text = "Once you're out of points, you'll end your turn by pressing R to let the enemies move and reset your action points. If you destroy the last enemy in the wave, your turn will end automatically.(Space to continue)";

        while (!Input.GetKeyDown(KeyCode.Space))
        {
            yield return null;
        }

        yield return null;

        tutorialText.text = "After controls, the goal of this game is to survive 3 waves of enemies coming at you. The descriptions of enemies are displayed on the right.";

        while (!Input.GetKeyDown(KeyCode.Space))
        {
            yield return null;
        }

        yield return null;

        tutorialText.text = "Each color matches the color of the enemy ship. In order to survive, you must destroy the enemy ships by dealing damage equal to their health.";

        while (!Input.GetKeyDown(KeyCode.Space))
        {
            yield return null;
        }

        yield return null;

        tutorialText.text = "But be careful, as if a ship makes it to the blue, they will take lives equal to their damage from you! If you run out of lives, you lose!";

        while (!Input.GetKeyDown(KeyCode.Space))
        {
            yield return null;
        }

        yield return null;

        tutorialText.text = "Have fun!";

        while (!Input.GetKeyDown(KeyCode.Space))
        {
            yield return null;
        }

        TurnManager.isPlayerTurn = false;
        tutorialText.text = "";
        tutorialOver = true;

        yield break;
    }
}
