using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace IndieMarc.TopDown
{
public class toggle : MonoBehaviour
{
    public bool changeToggle;
    public GameObject maincharacter;
  
    void Start()
    {
        
    }

   
    void Update()
    {  if (Input.GetKeyDown("q")){
           
        changeToggle = !changeToggle;
             
        if (changeToggle == true) {
            Debug.Log("Toggle");

            GetComponent<CAMERAZOOMOUT>().enabled = true;
            GetComponent<FollowCamera>().enabled = false;
            maincharacter.SetActive(false);
                 
        }else {
                 
            Debug.Log("!Toggle");
               GetComponent<CAMERAZOOMOUT>().enabled = false;
               GetComponent<FollowCamera>().enabled = true;
               maincharacter.SetActive(true);
         }
   
     }
    
     }
        
    }
}
