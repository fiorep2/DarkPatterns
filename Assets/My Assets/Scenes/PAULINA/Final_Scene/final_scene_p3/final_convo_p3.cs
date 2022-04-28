using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class final_convo_p3 : MonoBehaviour
{
    // Start is called before the first frame update
    public Image mc;
    public Image navy;
    public Image mc_emotion_1;
    public Image zuckering;
    

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
    
  

    public Button previous;
    public Button next;

    public GameObject canvasObject;
    public GameObject fadeObject;

    public GameObject Navy;
    public GameObject Yvan;

    public GameObject tripwire_yvan;

    public GameObject Video;

    public float currentimagevalue = 0.0f;

    

    void Start()
    {
     
        mc.enabled = false;
        mc_emotion_1.enabled = false;
        navy.enabled = false;
        zuckering.enabled = false;
         


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
         
         Navy.SetActive(true);
         Yvan.SetActive(false);
         Video.SetActive(false);
      
       

     
  
       

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
        mc.enabled = true;


        text2.enabled = false;
        text3.enabled = true;

        }else if(currentimagevalue == 4.0f){
        
        navy.enabled = true;
        mc.enabled = false;


        text3.enabled = false;
        text4.enabled = true;

        }else if(currentimagevalue == 5.0f){
        
        navy.enabled = false;
        mc.enabled = true;


        text4.enabled = false;
        text5.enabled = true;
  
        }else if(currentimagevalue == 6.0f){
        
        navy.enabled = true;
        mc.enabled = false;

        text5.enabled = false;
        text6.enabled = true;

        }else if(currentimagevalue == 7.0f){
        
        navy.enabled = false;
        mc.enabled = true;


        text6.enabled = false;
        text7.enabled = true;

        }else if(currentimagevalue == 8.0f){
        
        navy.enabled = false;
        mc.enabled = false;
        mc_emotion_1.enabled = true;


        text7.enabled = false;
        text8.enabled = true;

        
     
        }else if(currentimagevalue == 9.0f){
        
        mc_emotion_1.enabled = true;
        mc.enabled = false;


        text8.enabled = false;
        text9.enabled = true;
        Video.SetActive(false);


}else if(currentimagevalue == 10f){
        
       mc_emotion_1.enabled = true;
        mc.enabled = false;


        text9.enabled = false;
        text10.enabled = true;

}else if(currentimagevalue == 11f){
        
        mc_emotion_1.enabled = false;
        mc.enabled = true;


        text10.enabled = false;
        text11.enabled = true;

}else if(currentimagevalue == 12f){
        
        mc_emotion_1.enabled = true;
        mc.enabled = false;


        text11.enabled = false;
        text12.enabled = true;

}else if(currentimagevalue == 13f){
        
        mc_emotion_1.enabled = false;
        mc.enabled = true;


        text12.enabled = false;
        text13.enabled = true;

}else if(currentimagevalue == 14f){
        
        mc_emotion_1.enabled = true;
        mc.enabled = false;


        text13.enabled = false;
        text14.enabled = true;

}else if(currentimagevalue == 15f){
        
        mc_emotion_1.enabled = true;
        mc.enabled = false;


        text14.enabled = false;
        text15.enabled = true;

}else if(currentimagevalue == 16f){
        
       mc_emotion_1.enabled = true;
        mc.enabled = false;


        text15.enabled = false;
        text16.enabled = true;

}else if(currentimagevalue == 17f){
        
       mc_emotion_1.enabled = false;
        mc.enabled = false;
        zuckering.enabled = true;

        text16.enabled = false;
        text17.enabled = false;

}else if(currentimagevalue == 18f){
        
        mc_emotion_1.enabled = true;
        mc.enabled = false;


        text17.enabled = false;
        text18.enabled = false;
        Video.SetActive(true);
        canvasObject.SetActive(false);

        Invoke("newVoid", 52f);

         GetComponent<final_convo_p3>().enabled = false;
      
      Navy.SetActive(false);
       // Yvan.SetActive(true);
        tripwire_yvan.SetActive(false); 

               

       
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
               Video.SetActive(false);
               SceneManager.LoadScene("NavyBoss");
        //canvasObject.SetActive(true);
     
    }
}
