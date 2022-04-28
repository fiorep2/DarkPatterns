using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roach_maze_complete : MonoBehaviour
{
    public bool coin;
    public bool contract;
    public bool message;
    public bool reciept;
    public bool creditcard;

    public GameObject dooropen;
    public GameObject maze_exit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if(coin == true && contract == true && message == true && reciept == true && creditcard == true ){
     Debug.Log("YOU FOUND ALL THE ITEMS");
     
     dooropen.SetActive(true);
      GameObject.Find("door").GetComponent<tripwire_exitRM>().enabled = true;
    GameObject.Find("scripts").GetComponent<maze_exit_convo>().enabled = true;
      //maze_exit.SetActive(true);
     }
    }
}
