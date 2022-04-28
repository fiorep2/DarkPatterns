using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class signin_D1 : MonoBehaviour
{
  
public Renderer rend;
public Text Malicious_Text;
public Text Helpful_Text;
public GameObject levelcomplete;
public GameObject timer1;
public GameObject timer_navy;
public Image textbox_roger;
public Image textbox_navy;
public GameObject disable;

void Start(){ 
textbox_roger.GetComponent<Image>().enabled = false;
timer1.GetComponent<timer1>().enabled = false;
timer_navy.GetComponent<timer_navy>().enabled = false;
textbox_navy.GetComponent<Image>().enabled = false;
}
 
    
void OnMouseDown(){

levelcomplete.GetComponent<levelcomplete>().signin_D1 = true;
rend = GetComponent<Renderer>();
rend.enabled = false;
textbox_roger.GetComponent<Image>().enabled = true;
Malicious_Text.text = "ADDED 40 DAYS MOTEL STAY FOR $599!";
timer1.GetComponent<timer1>().enabled = true;
disable.GetComponent<disable>().enabled = false;





}
}
