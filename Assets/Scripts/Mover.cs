using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
   
   [SerializeField] float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
      PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
     movePlayer();
        
    } 

    void PrintInstruction(){
       Debug.Log("Welcome to the game");
       Debug.Log("Move the player with ASWD");
       Debug.Log("Dont hit the walls ");
    }

  void movePlayer(){
        float xValues = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float zValues = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
        transform.Translate(xValues,0,zValues);
    }

    

}
