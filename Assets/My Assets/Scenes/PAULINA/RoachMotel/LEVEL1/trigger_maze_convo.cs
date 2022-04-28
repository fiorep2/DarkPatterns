using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_maze_convo : MonoBehaviour
{
    public GameObject canvasObject;
    public GameObject scripts;

   void Start () {

   }
    
    

     
  void OnMouseDown(){
    
      canvasObject.SetActive(true); 
        GameObject.Find("scripts").GetComponent<maze_help_convo>().enabled = true;
      //GetComponent<maze_help_convo>().enabled = true;
      
     //Debug.Log("Clicked");
            
    }

     void OnMouseUp() {
       // canvasObject.SetActive(false); 
       // GameObject.Find("scripts").GetComponent<maze_help_convo>().enabled = false;
       
     }

   
}