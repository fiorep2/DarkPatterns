using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speech_trigger_yvan: MonoBehaviour

{
    public GameObject canvasObject;

   void Start () {

   }
    
    

     
  void OnMouseDown(){
    
      canvasObject.SetActive(true); 
     //Debug.Log("Clicked");
            
    }

   
       
}

