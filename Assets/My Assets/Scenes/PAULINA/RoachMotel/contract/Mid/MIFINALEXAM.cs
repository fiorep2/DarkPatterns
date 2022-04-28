using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MIFINALEXAM : MonoBehaviour
{
    // Start is called before the first frame update
    float hinput = 0;
    float vinput = 0;
    public float speed = 0.02f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hinput = Input.GetAxis("Horizontal");
        vinput = Input.GetAxis("Vertical");
        Debug.Log("hinput " + hinput + " vinput " + vinput);
        float posx = transform.position.x + speed * hinput;
        float posy = transform.position.y + speed * vinput;

        transform.position = new Vector3(posx,posy,-10);
    }
}
