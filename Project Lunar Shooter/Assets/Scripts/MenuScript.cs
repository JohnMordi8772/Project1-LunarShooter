/* Author: George Tang
//Assignment: Project Lunar Shooter
//Description: if needed adds script and prefab to multiple items using the menu tool
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuScript
{
    [MenuItem("Tools/Assign Tile Maaterial")]
    public static void AssignTileMaterial()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        Material material = Resources.Load<Material>("Tile");

        foreach (GameObject t in tiles)
        {
            t.GetComponent<Renderer>().material = material;
        }
    }

    [MenuItem("Tools/Assign Tile Script")]
    public static void AssignTileScript()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");

        foreach (GameObject t in tiles)
        {
            //t.AddComponent<Tile>();
        }
    }
}
