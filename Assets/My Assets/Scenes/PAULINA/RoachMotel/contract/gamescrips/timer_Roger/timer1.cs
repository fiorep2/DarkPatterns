using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer1 : MonoBehaviour
{


    public Text Malicious_Text;
    public Text Helpful_Text;
    public Image textbox;
    public Image textbox_navy;
    public float targetTime = 2.0f;
    public GameObject timer_navy;

   void Start(){
       timer_navy.GetComponent<timer_navy>().enabled = false;
         targetTime = 3.0f;
     
   }
    void Update()
    {
        targetTime -= Time.deltaTime;
        if (targetTime <= 0.0f){
            timerEnded();
            targetTime = 2.0f;
           
        }
    }

    void timerEnded(){
        //Debug.Log("timerended");
    textbox.GetComponent<Image>().enabled = false;
    Malicious_Text.text = " ";
    timer_navy.GetComponent<timer_navy>().enabled = true;
    textbox_navy.GetComponent<Image>().enabled = true;
    Helpful_Text.text = "Try signing in again";
     DestroyObject(gameObject);

    }
}
