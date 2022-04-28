using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class signin_D3 : MonoBehaviour
{
  
public Renderer rend;
public Text Malicious_Text;
public Text Helpful_Text;
public GameObject levelcomplete;
public GameObject timer3;
public GameObject timer_navy;
public Image textbox_roger;
public Image textbox_navy;
public GameObject disable;

void Start(){ 
textbox_roger.GetComponent<Image>().enabled = false;
timer3.GetComponent<timer3>().enabled = false;
timer_navy.GetComponent<timer_navy>().enabled = false;
textbox_navy.GetComponent<Image>().enabled = false;
}
 
    
void OnMouseDown(){

levelcomplete.GetComponent<levelcomplete>().signin_D3 = true;
rend = GetComponent<Renderer>();
rend.enabled = false;
textbox_roger.GetComponent<Image>().enabled = true;
Malicious_Text.text = "Acccess to CONTACTS GRANTED!";
timer3.GetComponent<timer3>().enabled = true;
disable.GetComponent<disable>().enabled = false;





}
}
