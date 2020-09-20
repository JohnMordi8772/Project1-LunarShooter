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

    // Start is called before the first frame update
    void Start()
    {
        isPlayerTurn = false;
        actionPoints = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            isPlayerTurn = !isPlayerTurn;
            actionPoints = 10;
        }

        totalPoints.text = "Action Points: " + actionPoints;
    }
}
