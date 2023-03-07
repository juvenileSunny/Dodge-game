using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

    int hits = 0;
    
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
            hits++;
            if(hits > 1)
            {
                Debug.Log("You have bumped so many times. You have bumped " + hits + " times");
            }
            else
            {
                Debug.Log("You have bumped into an obstacle");
            }
       
        }
        
    }
}
