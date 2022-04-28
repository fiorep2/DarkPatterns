using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class maze_exit_convo : MonoBehaviour
{
    public float currentimagevalue = 0.0f;

    public Text text1;
    public Image clippu;
    public AudioSource Sound1;
    public GameObject canvasObject;

     public Button previous;
     public Button next;

    // Start is called before the first frame update
    void Start()
    {
        text1.enabled = false;
        clippu.enabled = false;
        canvasObject.SetActive(true);
        //canvasObject.SetActive(false); 
       // GameObject.Find("scripts").GetComponent<maze_help_convo>().enabled = false;
    
        previous.onClick.AddListener(()=>{
            currentimagevalue = currentimagevalue -1;
            if(currentimagevalue < 0){
            currentimagevalue = 5;
            }
        });

        next.onClick.AddListener(()=>{
            currentimagevalue = currentimagevalue +1;
            if(currentimagevalue > 2){
       
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
         if(currentimagevalue == 1.0f){
      canvasObject.SetActive(true);
      
        text1.enabled = true;
        clippu.enabled = true;
            GameObject.Find("levelcomplete").GetComponent<roach_maze_complete>().enabled = false;

        }else if(currentimagevalue == 2.0f){
            text1.enabled = false;
            clippu.enabled = false;
           
    canvasObject.SetActive(false); 

       GameObject.Find("scripts").GetComponent<maze_exit_convo>().enabled = false;
        
       

        


        }else {
        text1.enabled = false;
        clippu.enabled = false;

       // canvasObject.SetActive(false); 
       // GameObject.Find("scripts").GetComponent<maze_help_convo>().enabled = false;
        
    }
}
}
