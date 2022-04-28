using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bounceobject : MonoBehaviour

{
    public GameObject wings;
    public float wingsspeed = 0.05f;
    bool toggle = false;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(toggle == false){
        wingsspeed = Random.Range(-0.01f,0.5f);
          float wingsx = wings.gameObject.transform.position.x + wingsspeed;
          wings.gameObject.transform.position = new Vector3(wingsx,0,0);
      }
        if(toggle == true){

             wingsspeed = Random.Range(0.01f,-0.8f);

          float wingsx = wings.gameObject.transform.position.x + wingsspeed;
          wings.gameObject.transform.position = new Vector3(wingsx,0,0);
             Debug.Log("hit");
      }
      if(wings.gameObject.transform.position.x >= 5){  
          toggle = true;
          
      }
      if(wings.gameObject.transform.position.x <= -5){  
          toggle = false;
          
      }
    }
}
/*flipflop 
2 sets of if statements
one has a boolean 
if position is < x booleon is true
if positoin is > x booleon is false

if moveball  = false, then make postition move in the position direction
one it reaches it 5, moveball is now true and if true move it in the negative direction
*/