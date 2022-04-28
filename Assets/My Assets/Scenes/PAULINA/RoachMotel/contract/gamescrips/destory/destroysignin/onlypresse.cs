using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onlypresse : MonoBehaviour
{
  
    public Renderer rend;
    public Text Malicious_Text;
    public GameObject levelcomplete;
    public Image textbox;
    // Start is called before the first frame update

    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    void Start()
    {   textbox.GetComponent<Image>().enabled = false;
        
    }

    // Update is called once per frame
    
    
   void OnMouseDown(){

   //GameObject varGameObject = GameObject.Find("sphere");   
   //then disable or enable script/component
 
     
   levelcomplete.GetComponent<levelcomplete>().signin_D = true;
   rend = GetComponent<Renderer>();
    rend.enabled = false;
    textbox.GetComponent<Image>().enabled = true;
    Malicious_Text.text = "YOU GAVE AWAY YOUR LOCATION!";
   // this object was clicked - do something
   //Destroy (this.gameObject,2f);
    //Destroy (GameObject.FindWithTag("flower"));
   //Destroy(this.GetComponent<MeshRenderer>());
 timerIsRunning = true;
   
  }
    
    void OnMouseUp(){
     
   
      //if (timerIsRunning){
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                Debug.Log("Time has run out!");
                  textbox.GetComponent<Image>().enabled = false;
                  Malicious_Text.text = "ened";
            }
            else
            {
                Debug.Log("else");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        
    }
    //}

    
}


