using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CAMERAZOOMOUT : MonoBehaviour
{

public float Speed = 50f;


  void Update()
     {
        float xAxisValue = Input.GetAxis("Horizontal") * Speed;
        float yAxisValue = Input.GetAxis("Vertical") * Speed;
        float zValue = 0.0f;
         if (Input.GetKey(KeyCode.Q))
         {
           
           transform.position = new Vector3 (0,0,-30);
           // zValue = -Speed;
      
          
           
         }
         if (Input.GetKey(KeyCode.E))
         {
         
             
            
         }
 
         transform.position = new Vector3(transform.position.x + xAxisValue, transform.position.y + yAxisValue,transform.position.z + zValue);
}
}
