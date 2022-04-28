using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveobject : MonoBehaviour

{
    public GameObject wings;
    public float wingsspeed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        wingsspeed = Random.Range(-0.01f,0.5f);
          float wingsx = wings.gameObject.transform.position.x + wingsspeed;
          wings.gameObject.transform.position = new Vector3(wingsx,0,0);
      if(wings.gameObject.transform.position.x >= 8){
          wings.gameObject.transform.position = new Vector3(1,0,0);
      }
    }
}
