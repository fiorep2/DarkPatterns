using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class signin_D : MonoBehaviour
{
  
public Renderer rend;
public Text Malicious_Text;
public Text Helpful_Text;
public GameObject levelcomplete;
public GameObject timer;
public GameObject timer_navy;
public GameObject disable;
public Image textbox_roger;
public Image textbox_navy;



void Start(){ 




textbox_roger.GetComponent<Image>().enabled = false;
timer.GetComponent<timer>().enabled = false;
timer_navy.GetComponent<timer_navy>().enabled = false;
textbox_navy.GetComponent<Image>().enabled = false;
}
 
    
void OnMouseDown(){

levelcomplete.GetComponent<levelcomplete>().signin_D = true;
rend = GetComponent<Renderer>();
rend.enabled = false;
textbox_roger.GetComponent<Image>().enabled = true;
Malicious_Text.text = "LOCATION ACCESS ENABLED!";
timer.GetComponent<timer>().enabled = true;
timer_navy.GetComponent<timer_navy>().enabled = false;
disable.GetComponent<disable>().enabled = false;

  
}


}
