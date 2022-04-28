using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class message_collected : MonoBehaviour
{
    public Text message_text_check;
    public GameObject levelcomplete;
      public AudioClip itemcollected;
    private AudioSource audioSource;
    void Start()
    {audioSource = gameObject.GetComponent<AudioSource> ();
        message_text_check.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D coll)
        {
            message_text_check.enabled = true;
            levelcomplete.GetComponent<roach_maze_complete>().message = true;

             audioSource.enabled = true;
            if (!audioSource.isPlaying) {
                audioSource.clip = itemcollected;
                audioSource.Play ();
            }
           Invoke("newVoid", 1);       
            
                    
              
            
        }
        void newVoid(){
        Destroy (this.gameObject);}
}
