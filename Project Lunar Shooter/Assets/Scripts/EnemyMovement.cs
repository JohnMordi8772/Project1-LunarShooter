﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public bool moved = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!TurnManager.isPlayerTurn)
        {
            if (!moved)
            {
                transform.Translate(new Vector3(0, 0, -1) * speed);
                moved = true;
            }
        }
        else
        {
            moved = false;
        }
    }
}