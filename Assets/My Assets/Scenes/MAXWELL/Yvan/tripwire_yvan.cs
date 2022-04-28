using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tripwire_yvan : MonoBehaviour
{
    public GameObject final_convo_p3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D coll){
       Invoke("newVoid", 1f);
    }

void newVoid(){
     final_convo_p3.SetActive(true);
       // Destroy(this);

}

}
