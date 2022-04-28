
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
 public class zoomout : MonoBehaviour
 {
     public float Speed = 50f;
     public GameObject maincamera;
     public GameObject self;

     public bool changeToggle;

     void Update()
     {
         //float xAxisValue = Input.GetAxis("Horizontal") * Speed;
         //float yAxisValue = Input.GetAxis("Vertical") * Speed;
         float zValue = 0.0f;
 
         if (Input.GetKey(KeyCode.w))
         {
            zValue = -Speed;
      
          
           
         }
         if (Input.GetKey(KeyCode.d))
         {
         
             
            
         }
 
         transform.position = new Vector3(transform.position.x, transform.position.y,transform.position.z + zValue);
    
    if (Input.GetKeyDown("r")){
           
        changeToggle = !changeToggle;
             
        if (changeToggle == true) {
            Debug.Log("Toggle");

            self.enabled = true;
            //self.SetActive(true);
            maincamera.SetActive(false);
                 
        }else {
                 
            Debug.Log("!Toggle");
            //self.SetActive(false);
            maincamera.SetActive(true);
            self.enabled = false;
         }
   
     }
    
     }

       
 }*/