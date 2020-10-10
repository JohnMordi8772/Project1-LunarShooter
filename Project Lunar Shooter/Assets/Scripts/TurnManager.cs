/*Author: Josh Bumbalough
//Assignment: Project Lunar Shooter
//Description: Manages the turns between the enemies and the player.
                Also displays text of action points.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TurnManager : MonoBehaviour
{
    public static bool isPlayerTurn; 
    public static float actionPoints;
    public Text totalPoints;
    public Text playerTurn;

    // Start is called before the first frame update
    void Start()
    {
        isPlayerTurn = true;
        if(Tutorial.tutorialOver)
            actionPoints = 8;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && Tutorial.tutorialOver && actionPoints <= 0)//R switches the turns between enemy and player for right now as we had to get other things done,
                                       //so the enemy turn doesn't end automatically
        {
            isPlayerTurn = !isPlayerTurn;
        }

        if(!isPlayerTurn)
        {
            actionPoints = 8;
        }

        if(actionPoints <= 0)
        {
                actionPoints = 0;
        }
        totalPoints.text = "Action Points: " + actionPoints;
    }
}
