using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class final_convo_p2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Image mc;
    public Image navy;
    public Image mc_emotion_1;
    

    public Text text1;
    public Text text2;
    public Text text3;

    public GameObject Navy;
    public GameObject SpeechBubble;
    public GameObject Key;
   
 
  
  
    
  

    public Button previous;
    public Button next;

    public GameObject canvasObject;
    public GameObject fadeObject;
    public float currentimagevalue = 0.0f;

    

    void Start()
    {
     
        mc.enabled = false;
        mc_emotion_1.enabled = false;
        navy.enabled = false;
         


        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
          Key.SetActive(false);
         
      
       

     
  
       

        //imageslider.onValueChanged.AddListener(delegate{
            //Debug.Log(imageslider.value);
           // currentimagevalue = imageslider.value;
        //});



        //previous.onClick.AddListener(previmage);
        previous.onClick.AddListener(()=>{
            currentimagevalue = currentimagevalue -1;
            if(currentimagevalue < 0){
            //if(currentimagevalue <= -1){
                //currentimagevalue = 0;
                currentimagevalue = 5;
            }
        });

        next.onClick.AddListener(()=>{
            currentimagevalue = currentimagevalue +1;
           
        });
    }

    // Update is called once per frame
    void Update()
    {
        // if(currentimagevalue == 1.0f){
        //     chameleon.enabled = true;
        // }

        // if(currentimagevalue == 2.0f){
        //     chimpanzee.enabled = true;
        // }

        //Debug.Log(imageslider.value);

        if(currentimagevalue == 1.0f){
        navy.enabled = false;
        mc.enabled = true;


        text1.enabled = true;
       

     
        }else if(currentimagevalue == 2.0f){
        navy.enabled = true;
        mc.enabled = false;


        text1.enabled = false;
        text2.enabled = true;
      

      
        
        

        }else if(currentimagevalue == 3.0f){
        
        navy.enabled = false;
        mc.enabled = false;


        text2.enabled = false;
        text3.enabled = true;
  

     

                            
        }else if(currentimagevalue == 4.0f){
       
      GetComponent<final_convo_p2>().enabled = false;
      canvasObject.SetActive(false);
      fadeObject.SetActive(true);

        Navy.SetActive(false);
        SpeechBubble.SetActive(false);
        Key.SetActive(true);

        Invoke("newVoid", 1); 
        
       
       

       
        }
        else{
            //default condition
        mc.enabled = false;
        mc_emotion_1.enabled = false;
        navy.enabled = false;
         
        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
         

        
        
        
        }
    }

     void newVoid(){
          fadeObject.SetActive(false);
     
    }
}
