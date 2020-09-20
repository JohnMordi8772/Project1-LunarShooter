using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public static bool isPlayerTurn; 
    public static float actionPoints;

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


    }
}
