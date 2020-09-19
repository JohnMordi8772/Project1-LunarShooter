/*Author: George Tang
 * Assignment: Project Lunar Shooter
 * Desciption: Checking Tile Occupancy and decide to movement of tiles from player/enemy
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool walkable = true;
    public bool current = false;
    public bool target = false;
    public bool selectable = false;

    public List<Tile> adjacencyList = new List<Tile>();

    //needed BFS (breadth first search)
    public bool visited = false;
    public Tile parent = null;
    public int distance = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (current)
        {
            GetComponent<Renderer>().material.color = Color.magenta;
        }
        else if (target)
        {
            GetComponent<Renderer>().material.color = Color.green;
        }

        else if (selectable)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.white;
        
        }
    }
    public void Reset()
    {
        adjacencyList.Clear();

        walkable = true;
        current = false;
        target = false;
        selectable = false;

        visited = false;
        parent = null;
        distance = 0;
    }

    //jumpHeight = to allow player to jump platforms = y-axis
    // finding neighbor tiles = next to player right.left, forward, up and down (z-axis)
    public void FindNeighbors(float jumpHeight)
    {
        Reset();
        //x-axis
        CheckTile(Vector3.forward, jumpHeight);
        CheckTile(-Vector3.forward, jumpHeight);
        //z-axis
        CheckTile(Vector3.right, jumpHeight);
        CheckTile(-Vector3.right, jumpHeight);

    }

    public void CheckTile(Vector3 direction, float jumpHeight)
    {
        Vector3 halfExtends = new Vector3(0.25f, (1 + jumpHeight) / 2.0f, 0.25f);
        // attempting if their are tiles next to the objects
        Collider[] colliders = Physics.OverlapBox(transform.position + direction, halfExtends);

        foreach  (Collider item in colliders)
        {
            Tile tile = item.GetComponent<Tile>();
            //checking if objects if tiles player (dont care) 
            // checking if tile is walkable
            if (tile != null && tile.walkable)
            {
                //testing if their are objects in the tile area
                // tile = if something there add dont add it if nothing there add to list
                // nothing sitting on the tile
                RaycastHit hit;
                if (!Physics.Raycast(tile.transform.position, Vector3.up, out hit, 1))
                {

                    adjacencyList.Add(tile);
                }
            }
        }
    }
}
