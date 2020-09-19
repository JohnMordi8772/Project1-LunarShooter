/*Author: George Tang
 * Assignment: Project Lunar Shooter
 * Desciption: Allows player to rotate the camera using buttons on screen
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacticsCamera : MonoBehaviour
{
    public void RotateLeft()
    {
        transform.Rotate(Vector3.up, 90, Space.Self);
    }

    public void RotateRight()
    {
        transform.Rotate(Vector3.up, -90, Space.Self);
    }
}
