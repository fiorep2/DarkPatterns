using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer_navy : MonoBehaviour
{


    public Text Helpful_Text;
    public Image textbox_navy;
    public float targetTime = 3.0f;
    //public GameObject timer;
    public GameObject disable;
    
  

   void Start(){

       
   }
    void Update()
    {
        targetTime -= Time.deltaTime;
        if (targetTime <= 0.0f){
            targetTime = 3.0f;
            timerEnded();
        }
    }

    void timerEnded(){
        Debug.Log("timerended");
        textbox_navy.GetComponent<Image>().enabled = false;
    Helpful_Text.text = "";
//timer.GetComponent<timer>().enabled = false;
  disable.GetComponent<disable>().enabled = true;
     
    }
}
