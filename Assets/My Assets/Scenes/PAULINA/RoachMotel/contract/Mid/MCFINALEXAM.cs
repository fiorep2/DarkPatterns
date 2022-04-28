using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCFINALEXAM: MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.02f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) == true){
            transform.position = transform.position + Vector3.up * speed;
            Debug.Log("transform position y:" + transform.position.y + "Vector3 up:" + Vector3.up);
        }
        if(Input.GetKey(KeyCode.DownArrow) == true ){
            transform.position += Vector3.down * speed;
        }
        if(Input.GetKey(KeyCode.LeftArrow) == true){
            transform.position += Vector3.left * speed;
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.position += Vector3.right * speed;
        }
    }
}
