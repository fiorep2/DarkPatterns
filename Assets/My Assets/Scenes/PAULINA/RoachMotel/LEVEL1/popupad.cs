using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popupad : MonoBehaviour
{
  
public Renderer rend;
public GameObject roach;
public GameObject signupad;





void Start(){ 




}
 
    
void OnMouseDown(){


rend = GetComponent<Renderer>();
rend.enabled = false;
roach.SetActive(true);

 Destroy(signupad,1);



  
}


}
