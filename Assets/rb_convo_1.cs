using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rb_convo_1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Image mc;
    public Image roger;
  


    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
   
    public Button previous;
    public Button next;

    public GameObject canvasObject;
    public GameObject fadeObject;
  
    public GameObject level_Shake;
    public GameObject level_Shake2;


   

    public float currentimagevalue = 0.0f;

    

    void Start()
    {
     
        mc.enabled = false;
        roger.enabled = false;
       

        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
        text4.enabled = false;
     
      
       

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
        mc.enabled = true;
        roger.enabled = false;
       

        text1.enabled = true;
        text2.enabled = false;
        text3.enabled = false;
        text4.enabled = false;
      
            

     
        }else if(currentimagevalue == 2.0f){
        mc.enabled = false;
        roger.enabled = true;
       

        text1.enabled = false;
        text2.enabled = true;
        text3.enabled = false;
        text4.enabled = false;

        }else if(currentimagevalue == 3.0f){
        mc.enabled = true;
        roger.enabled = false;
       

        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = true;
        text4.enabled = false;

        }else if(currentimagevalue == 4.0f){
        mc.enabled = false;
        roger.enabled = true;
       

        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
        text4.enabled = true;

        }else if(currentimagevalue == 5.0f){
    
       
      GetComponent<rb_convo_1>().enabled = false;
      canvasObject.SetActive(false);
      
      level_Shake.SetActive(false);
      level_Shake2.SetActive(true);
      Invoke("newVoid", 0.5f);
       
    
     
        }
        else{
            //default condition
        mc.enabled = false;
       
        roger.enabled = false;
        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
        text4.enabled = false;
       
        }

         
    }

   void newVoid(){
       fadeObject.SetActive(true);
        SceneManager.LoadScene("roach_boss");
     
        }
}
