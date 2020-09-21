/*Author: John Mordi
//Assignment: Project Lunar Shooter
//Description: Checks win/loss conditions and adjusts in game text respectivly.
               Also, this allows the player to restart when they win or lose.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinLossManager : MonoBehaviour
{
    public Text livesOrGameOver;

    public static bool win;
    public static bool gameover;
    public static float lives;

    // Start is called before the first frame update
    void Start()
    {
        win = false;
        gameover = false;
        lives = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameover)
        {
            livesOrGameOver.text = "Lives: " + lives;
        }
        if(lives <= 0)
        {
            gameover = true;
        }
        if(gameover)
        {
            if(win)
            {
                livesOrGameOver.text = "Congratulations, you win!\nPress R to play again.";
            }
            else
            {
                livesOrGameOver.text = "Sorry, you lost.\nPress R to try again.";
            }
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
