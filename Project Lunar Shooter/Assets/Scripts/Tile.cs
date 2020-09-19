/*Author: George Tang
//Assignment: Project Lunar Shooter
//Description: color for tiles indications show player movement possibilities. 
               Checks if tiles are occupied
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool walkable = false;
    public bool current = false;
    public bool target = false;
    public bool selectable = false;

    public List<Tile> adjacencyList = new List<Tile>();

    public bool visited = false;
    public Tile parent = null;
    // forcing player or enemy to move a selected amt of distance
    public int distance = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // show player's current position
        if (current)
        {
            GetComponent<Renderer>().material.color = Color.magenta;
        }

        // shows move possibility
        else if (target)
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
        // shows move selected that can be made
        else if (selectable)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        // default to original shade of grass or white
        else
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }

    public void Reset()
    {
        adjacencyList.Clear();
         current = false;
         target = false;
         selectable = false;

         visited = false;
         parent = null;
         // forcing player or enemy to move a selected amt of distance
         distance = 0;

    }

    // jumpHeight = how many players they can jump up or down
    public void FindNeighbors(float jumpHeight)
    {
        Reset();

        CheckTile(Vector3.forward, jumpHeight);
        //opposite function
        CheckTile(-Vector3.forward, jumpHeight);
        //z axis
        CheckTile(Vector3.right, jumpHeight);
        CheckTile(-Vector3.right, jumpHeight);
    }
    

    public void CheckTile(Vector3 direction, float jumpHeight)
    {
        // finding tiles
        Vector3 halfExtends = new Vector3(0.25f,(1+jumpHeight)/2.0f,0.25f);
        Collider[] colliders = Physics.OverlapBox(transform.position + direction, halfExtends);

        foreach (Collider item in colliders)
        {
            // checking for tiles
            Tile tile = item.GetComponent<Tile>();
            if (tile != null && tile.walkable)
            {
                RaycastHit hit;
                //testing if there something on tie, if something dont add, if nothing then we add it
                if (!Physics.Raycast(tile.transform.position, Vector3.up, out hit, 1))
                {
                    adjacencyList.Add(tile);
                }
            }
        }
    }
    
}



