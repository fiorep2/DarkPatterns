using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakextripwaire : MonoBehaviour
{
    public GameObject fake_convo_xs_2;
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
     fake_convo_xs_2.SetActive(true);
        Destroy(this);

}

}
