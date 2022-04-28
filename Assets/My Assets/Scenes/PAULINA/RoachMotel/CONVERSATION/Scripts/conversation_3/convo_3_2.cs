using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class convo_3_2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Image mc;
    public Image navvy;
    public Image mc_dissaproval;
    public Image roger;
    public Image mc_fade;
    public Image navvy_fade;
    public Image Roger_fade;
    public Image items;


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

    public Button previous;
    public Button next;

    public GameObject canvasObject;
    public GameObject fadeObject;
    public GameObject clippuu;

    public GameObject tripwire;
    public GameObject dooropen;

    public float currentimagevalue = 0.0f;

    

    void Start()
    {
     
        mc.enabled = false;
        mc_dissaproval.enabled = false;
        navvy.enabled = false;
        roger.enabled = false;
        items.enabled = false;

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

        mc_fade.enabled = false;
        navvy_fade.enabled = false;
        Roger_fade.enabled = false;
       

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
        mc.enabled = false;
        navvy.enabled = false;
        roger.enabled = true;
        items.enabled = false;

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

        mc_fade.enabled = false;
        navvy_fade.enabled = false;
        Roger_fade.enabled = false;
            

     
        }else if(currentimagevalue == 2.0f){
        mc.enabled = true;
        mc_dissaproval.enabled = false;
        navvy.enabled = false;
        roger.enabled = false;
        items.enabled = false;

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

      mc_fade.enabled = false;
        navvy_fade.enabled = false;
        Roger_fade.enabled = false;

        }else if(currentimagevalue == 3.0f){
        mc.enabled = false;
        mc_dissaproval.enabled = false;
        navvy.enabled = false;
        roger.enabled = true;
        items.enabled = false;

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

        mc_fade.enabled = false;
        navvy_fade.enabled = false;
        Roger_fade.enabled = false;

        }else if(currentimagevalue == 4.0f){
        mc.enabled = false;
        mc_dissaproval.enabled = false;
        navvy.enabled = true;
        roger.enabled = false;
        items.enabled = false;

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

        mc_fade.enabled = false;
        navvy_fade.enabled = false;
        Roger_fade.enabled = false;

        }else if(currentimagevalue == 5.0f){
        mc.enabled = false;
        mc_dissaproval.enabled = false;
        navvy.enabled = false;
        roger.enabled = true;
        items.enabled = false;

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

       mc_fade.enabled = false;
        navvy_fade.enabled = false;
        Roger_fade.enabled = false;
        
        
        }else if(currentimagevalue == 6.0f){
        mc.enabled = false;
        mc_dissaproval.enabled = true;
        navvy.enabled = false;
        roger.enabled = false;
        items.enabled = false;

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

       mc_fade.enabled = false;
        navvy_fade.enabled = false;
        Roger_fade.enabled = false;


         }else if(currentimagevalue == 7.0f){
        mc.enabled = true;
        mc_dissaproval.enabled = false;
        navvy.enabled = false;
        roger.enabled = false;
        items.enabled = false;

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

        mc_fade.enabled = false;
        navvy_fade.enabled = false;
        Roger_fade.enabled = false;

        }else if(currentimagevalue == 8.0f){
        mc.enabled = false;
        mc_dissaproval.enabled = false;
        navvy.enabled = false;
        roger.enabled = true;
        items.enabled = false;

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

        mc_fade.enabled = false;
        navvy_fade.enabled = false;
        Roger_fade.enabled = false;

        }else if(currentimagevalue == 9.0f){
        mc.enabled = false;
        mc_dissaproval.enabled = false;
        navvy.enabled = false;
        roger.enabled = true;
        items.enabled = false;

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

        mc_fade.enabled = false;
        navvy_fade.enabled = false;
        Roger_fade.enabled = false;

        }else if(currentimagevalue == 10f){
        mc.enabled = false;
        mc_dissaproval.enabled = false;
        navvy.enabled = false;
        roger.enabled = true;
        items.enabled = true;

        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
        text4.enabled = false;
        text5.enabled = false;
        text6.enabled = false;
        text7.enabled = false;
        text8.enabled = false;
        text9.enabled = false;
        text10.enabled = true;

        mc_fade.enabled = false;
        navvy_fade.enabled = false;
        Roger_fade.enabled = false;


       
        }else if (currentimagevalue == 11f){
       
      GetComponent<convo_3_2>().enabled = false;
      canvasObject.SetActive(false);
      tripwire.SetActive(true);
      dooropen.SetActive(true);
      
      fadeObject.SetActive(true);
      
      Invoke("newVoid", 0.5f);
       
    
     
        }
        else{
            //default condition
        mc.enabled = false;
        mc_dissaproval.enabled = false;
        navvy.enabled = true;
        roger.enabled = false;
        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
        text4.enabled = false;
        text5.enabled = true;
        text6.enabled = false;
        text7.enabled = false;
        text8.enabled = false;

        mc_fade.enabled = false;
        navvy_fade.enabled = false;
        Roger_fade.enabled = false;
        }

         
    }

    void newVoid(){
        clippuu.SetActive(false);
     
        }
}
