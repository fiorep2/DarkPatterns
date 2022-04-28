using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Text helptext;
    public bool help = false;
    public Button helpbutton;
    // Start is called before the first frame update
    void Start()
    {
        helpbutton.onClick.AddListener(helpenable);
    }

    // Update is called once per frame
    void Update(){

    if(help == true){
        helptext.text = "YOU NEED HELP";
    }else{
        help = false;
    }
    
        
    }
    void helpenable(){
        help = true;
    }
}
