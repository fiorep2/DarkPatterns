using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gotoRb_Death : MonoBehaviour
{
  public GameObject fadeout;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Invoke("newVoid",3f);
        Invoke("newVoid2",3.5f);
        
    }

    void newVoid(){
    fadeout.SetActive(true);


    }

    void newVoid2(){
        SceneManager.LoadScene("Final Level");

    }
}
