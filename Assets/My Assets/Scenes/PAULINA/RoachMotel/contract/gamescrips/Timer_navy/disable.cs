using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class disable : MonoBehaviour
{
    public GameObject timer_navy;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        timer_navy.GetComponent<timer_navy>().enabled = false;
     
    }
}
