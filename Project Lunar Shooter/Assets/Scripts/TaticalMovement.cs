//Author: George Tang
//Assignment: Project Lunar Shooter
//Description: Tile Movement and highlights for possible movements

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaticalMovement : MonoBehaviour
{
    // highlights tile. maybe not be the right sprite?

    List<SpriteTileMode> selectedTiles = new List<SpriteTileMode>();
    public int move = 5;
    public float jumpHeight = 2;

    Vector3 velocity = new Vector3();
    Vector3 heading = new Vector3();
    
   
}
