using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tut_convo_1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Image mc;
    public Image navvy;
    public Image mc_emotion_1;
    public Image anti_virus;
    public Image username;
  
    


    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text9;
    public Text text10;

    public Text text11;
    public Text text12;
    public Text text13;
    public Text text14;
    public Text text15;
    public Text text16;
    public Text text17;
    public Text text18;
    public Text text19;
    public Text text20;

    public Text text21;
    public Text text22;
  
    
  

    public Button previous;
    public Button next;

    public GameObject canvasObject;
    public GameObject fadeObject;
    public float currentimagevalue = 0.0f;

    

    void Start()
    {
     
        mc.enabled = false;
        mc_emotion_1.enabled = false;
        navvy.enabled = false;
        anti_virus.enabled = false;
         
        username.enabled = false;


        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
        text4.enabled = false;
        text5.enabled = false;
        text6.enabled = false;
        text7.enabled = false;
        text8.enabled = false;
        text9.enabled = false;
        text10.enabled = false;

        text11.enabled = false;
        text12.enabled = false;
        text13.enabled = false;
        text14.enabled = false;
        text15.enabled = false;
        text16.enabled = false;
        text17.enabled = false;
        text18.enabled = false;
        text19.enabled = false;
        text20.enabled = false;
        
        text21.enabled = false;
        text22.enabled = false;

     
  
       

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
        username.enabled = false;
        mc.enabled = true;
        navvy.enabled = false;
        anti_virus.enabled = false;
         

        text1.enabled = true;
        text2.enabled = false;
        text3.enabled = false;
        text4.enabled = false;
        text5.enabled = false;
        text6.enabled = false;
        text7.enabled = false;
        text8.enabled = false;
        text9.enabled = false;
        text10.enabled = false;

        text11.enabled = false;
        text12.enabled = false;
        text13.enabled = false;
        text14.enabled = false;
        text15.enabled = false;
        text16.enabled = false;
        text17.enabled = false;
        text18.enabled = false;
        text19.enabled = false;
        text20.enabled = false;

     
        }else if(currentimagevalue == 2.0f){
        mc.enabled = false;
        mc_emotion_1.enabled = false;
        navvy.enabled = true;
        anti_virus.enabled = false;
         

        text1.enabled = false;
        text2.enabled = true;
        text3.enabled = false;
        text4.enabled = false;
        text5.enabled = false;
        text6.enabled = false;
        text7.enabled = false;
        text8.enabled = false;
        text9.enabled = false;
        text10.enabled = false;

        text11.enabled = false;
        text12.enabled = false;
        text13.enabled = false;
        text14.enabled = false;
        text15.enabled = false;
        text16.enabled = false;
        text17.enabled = false;
        text18.enabled = false;
        text19.enabled = false;
        text20.enabled = false;

      
        
        

        }else if(currentimagevalue == 3.0f){
        mc.enabled = true;
        mc_emotion_1.enabled = false;
        navvy.enabled = false;
        anti_virus.enabled = false;
         

        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = true;
        text4.enabled = false;
        text5.enabled = false;
        text6.enabled = false;
        text7.enabled = false;
        text8.enabled = false;
        text9.enabled = false;
        text10.enabled = false;

        text11.enabled = false;
        text12.enabled = false;
        text13.enabled = false;
        text14.enabled = false;
        text15.enabled = false;
        text16.enabled = false;
        text17.enabled = false;
        text18.enabled = false;
        text19.enabled = false;
        text20.enabled = false;

        
        
        

        }else if(currentimagevalue == 4.0f){
        mc.enabled = false;
        mc_emotion_1.enabled = false;
        navvy.enabled = true;
        anti_virus.enabled = false;
         

        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
        text4.enabled = true;
        text5.enabled = false;
        text6.enabled = false;
        text7.enabled = false;
        text8.enabled = false;
        text9.enabled = false;
        text10.enabled = false;

        text11.enabled = false;
        text12.enabled = false;
        text13.enabled = false;
        text14.enabled = false;
        text15.enabled = false;
        text16.enabled = false;
        text17.enabled = false;
        text18.enabled = false;
        text19.enabled = false;
        text20.enabled = false;

        
        
        

        }else if(currentimagevalue == 5.0f){
        mc.enabled = false;
        mc_emotion_1.enabled = false;
        navvy.enabled = true;
        anti_virus.enabled = false;
         

        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
        text4.enabled = false;
        text5.enabled = true;
        text6.enabled = false;
        text7.enabled = false;
        text8.enabled = false;
        text9.enabled = false;
        text10.enabled = false;

        text11.enabled = false;
        text12.enabled = false;
        text13.enabled = false;
        text14.enabled = false;
        text15.enabled = false;
        text16.enabled = false;
        text17.enabled = false;
        text18.enabled = false;
        text19.enabled = false;
        text20.enabled = false;

        
        }else if(currentimagevalue == 6.0f){
        mc.enabled = false;
        mc_emotion_1.enabled = true;
        navvy.enabled = false;
        anti_virus.enabled = false;
         

        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
        text4.enabled = false;
        text5.enabled = false;
        text6.enabled = true;
        text7.enabled = false;
        text8.enabled = false;
        text9.enabled = false;
        text10.enabled = false;


        text11.enabled = false;
        text12.enabled = false;
        text13.enabled = false;
        text14.enabled = false;
        text15.enabled = false;
        text16.enabled = false;
        text17.enabled = false;
        text18.enabled = false;
        text19.enabled = false;
        text20.enabled = false;


        }else if(currentimagevalue == 7.0f){
        mc.enabled = false;
        mc_emotion_1.enabled = false;
        navvy.enabled = true;
        anti_virus.enabled = false;
         

        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
        text4.enabled = false;
        text5.enabled = false;
        text6.enabled = false;
        text7.enabled = true;
        text8.enabled = false;
        text9.enabled = false;
        text10.enabled = false;

        text11.enabled = false;
        text12.enabled = false;
        text13.enabled = false;
        text14.enabled = false;
        text15.enabled = false;
        text16.enabled = false;
        text17.enabled = false;
        text18.enabled = false;
        text19.enabled = false;
        text20.enabled = false;

        
        
        

        }else if(currentimagevalue == 8.0f){
        mc.enabled = true;
        mc_emotion_1.enabled = false;
        navvy.enabled = false;
        anti_virus.enabled = false;
         

        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
        text4.enabled = false;
        text5.enabled = false;
        text6.enabled = false;
        text7.enabled = false;
        text8.enabled = true;
        text9.enabled = false;
        text10.enabled = false;

        text11.enabled = false;
        text12.enabled = false;
        text13.enabled = false;
        text14.enabled = false;
        text15.enabled = false;
        text16.enabled = false;
        text17.enabled = false;
        text18.enabled = false;
        text19.enabled = false;
        text20.enabled = false;


        }else if(currentimagevalue == 9.0f){
        mc.enabled = false;
        mc_emotion_1.enabled = false;
        navvy.enabled = true;
        anti_virus.enabled = false;
         

        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
        text4.enabled = false;
        text5.enabled = false;
        text6.enabled = false;
        text7.enabled = false;
        text8.enabled = false;
        text9.enabled = true;
        text10.enabled = false;

        text11.enabled = false;
        text12.enabled = false;
        text13.enabled = false;
        text14.enabled = false;
        text15.enabled = false;
        text16.enabled = false;
        text17.enabled = false;
        text18.enabled = false;
        text19.enabled = false;
        text20.enabled = false;

        

        }else if(currentimagevalue == 10f){
     
        text9.enabled = false;
        username.enabled = true;



        }else if(currentimagevalue == 11f){
        mc.enabled = true;
        navvy.enabled = false;
        text10.enabled = false;
        text11.enabled = true;
       
       

        }else if(currentimagevalue == 12f){
        mc.enabled = false;
        navvy.enabled = true;
        text11.enabled = false;
        text12.enabled = true;
       

        }else if(currentimagevalue == 13f){
        mc.enabled = true;
        navvy.enabled = false;
        text12.enabled = false;
        text13.enabled = true;
      

        }else if(currentimagevalue == 14f){
        mc.enabled = false;
        navvy.enabled = true;
        text13.enabled = false;
        text14.enabled = true;
       

        }else if(currentimagevalue == 15f){
        mc.enabled = true;
        navvy.enabled = false;
        text14.enabled = false;
        text15.enabled = true;
      
        
        }else if(currentimagevalue == 16f){
       
        text15.enabled = false;
        text16.enabled = true;
       

        }else if(currentimagevalue == 17f){
        mc.enabled = false;
        navvy.enabled = true;
        text16.enabled = false;
        text17.enabled = true;
    
                   
                   
        }else if(currentimagevalue == 18f){
        text17.enabled = false;
        text18.enabled = true;
     

        }else if(currentimagevalue == 19f){
        
        text18.enabled = false;
        text19.enabled = true;

        }else if(currentimagevalue == 20f){
        mc.enabled = true;
        navvy.enabled = false;
        text19.enabled = false;
        text20.enabled = true;

        }else if(currentimagevalue == 21f){
        mc.enabled = false;
        navvy.enabled = true;
        text20.enabled = false;
        text21.enabled = true;

        }else if(currentimagevalue == 22f){
        mc.enabled = false;
        navvy.enabled = true;
        text21.enabled = false;
        text22.enabled = true;

    
     

                            
        }else if(currentimagevalue == 23f){
       
      GetComponent<tut_convo_1>().enabled = false;
      canvasObject.SetActive(false);
      fadeObject.SetActive(true);
    
        Invoke("newVoid", 2); 
        
    
       
    
     
        }
        else{
            
        mc.enabled = false;
        mc_emotion_1.enabled = false;
        navvy.enabled = false;
   
        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
        text4.enabled = false;
        text5.enabled = true;
        text6.enabled = false;
        text7.enabled = false;
        text8.enabled = false;

        
        
        
        }
    }

    

    void newVoid(){
        SceneManager.LoadScene("Tutorial");
     
    }
}
