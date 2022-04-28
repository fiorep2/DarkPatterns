using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyClick : MonoBehaviour
{
    
    public Text wingstext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
  void OnMouseDown(){

      GameObject varGameObject = GameObject.Find("scripts");   
  //then disable or enable script/component
 
    varGameObject.GetComponent<bounceobject>().enabled = false;
         // this object was clicked - do something
     Destroy (this.gameObject,2f);
     //Destroy(this.GetComponent<MeshRenderer>());
     wingstext.text = "✓";
    wingstext.color = new Color32(0,255,0,255);// rang is 0 - 255
  }  
}
