using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class final_convo_p2_1 : MonoBehaviour
{
    // Start is called before the first frame update

    public Image navy; 
    public Text text1;

  

    public Button previous;
    public Button next;

    public GameObject canvasObject;
    public GameObject fadeObject;
    public float currentimagevalue = 0.0f;

    

    void Start()
    {
     
        
        navy.enabled = false;
        text1.enabled = false;
  
         
      
       

     
  
       

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
        navy.enabled = true;
        text1.enabled = true;
       

                            
        }else if(currentimagevalue == 2.0f){
       
      GetComponent<final_convo_p2>().enabled = false;
      canvasObject.SetActive(false);
      fadeObject.SetActive(true);

        /*Invoke("newVoid", 2); 
        
        DEFINE NEW VOID FIRST AT THE BOTTOM OF THE SCRIPT,
        THEN REMOVE THE CENSOR
        */
       

       
        }
        else{
            //default condition
      
        navy.enabled = true;
        text1.enabled = false;
      
         

        
        
        
        }
    }

     /*void newVoid(){
        SceneManager.LoadScene("NAME OF SCENE HERE");
     
    }*/
}
