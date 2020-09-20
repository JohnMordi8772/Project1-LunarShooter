using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
        private void OnTriggerEnter(Collider other)
        {
            //displayScoreScript.score++;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    
}
