using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{   
    MeshRenderer renderer;
    Rigidbody rigitB;
   [SerializeField] float timeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
      renderer = GetComponent<MeshRenderer>();
      renderer.enabled = false;
      rigitB = GetComponent<Rigidbody>();
      rigitB.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        waitAndFall();
    }

    void waitAndFall(){
        
        
        if(Time.time>timeToWait){
           renderer.enabled = true;
           rigitB.useGravity = true;
        }
    }
}
