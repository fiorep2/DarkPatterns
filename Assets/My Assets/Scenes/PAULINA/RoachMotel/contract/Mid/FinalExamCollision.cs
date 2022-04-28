using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalExamCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public Text pb;
    public Text tb;
    public Text c;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col){
        Debug.Log("collision: " + col.gameObject.name);
        if(col.gameObject.name == "pbtrigger"){
            pb.text = ":)";
            pb.color = new Color32(0,255,0,255);// rang is 0 - 255
        }
        if(col.gameObject.name == "tbtrigger"){
            tb.text = "cool bro";
            tb.color = new Color32(0,255,0,255);// rang is 0 - 255
        }
         if(col.gameObject.name == "ctrigger"){
            c.text = "cool bro";
            c.color = new Color32(0,255,0,255);// rang is 0 - 255
        }
    }
    }

