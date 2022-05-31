using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int hitCount =0;
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag != "Hit")
        {
            hitCount++;
            Debug.Log("You've bumped into a thing "+hitCount+" times");
        }
        
    }
  
}
