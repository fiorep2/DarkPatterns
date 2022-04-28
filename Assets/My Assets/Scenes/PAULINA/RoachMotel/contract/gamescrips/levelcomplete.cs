using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class levelcomplete : MonoBehaviour
{
    public bool signin_D;
    public bool signin_D1;
    public bool signin_D2;
    public bool signin_D3;
    public bool signin_D4;

    //  public float targetTime = 2.0f;

    public GameObject fadeObject;
  

    //public Button buttonlevelcomplete;
    // Start is called before the first frame update
    void Start()
    {
        bool signin_D = false;
        bool signin_D1 = false;
        bool signin_D2 = false;
        bool signin_D3 = false;
        bool signin_D4 = false;
      
    }

    // Update is called once per frame
    void Update()
    {
        //if( sword = true){ Debug.Log("it works");}
    if(signin_D == true && signin_D1 == true && signin_D2 == true && signin_D3 == true && signin_D4 == true ){
     Debug.Log("YOU FOUND ALL THE ITEMS");

    // fadeObject.SetActive(true);
    Invoke("newVoid", 1); //2 is the time
    

    /*targetTime -= Time.deltaTime;
        if (targetTime <= 0.0f){
            targetTime = 2.0f;
            timerEnded();
        }
    */
       
     }
        
    }


    void newVoid(){
        SceneManager.LoadScene("Conversation_2");
     
    }
}
