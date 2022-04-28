using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class startvideo : MonoBehaviour
{
   // public Button playsound;
    //public Button playvideo;
    public Button playboth;

    public AudioSource wavesound;
    public VideoPlayer wavevideo;

   // bool soundtoggle = false;
   // bool videotoggle = false;
    bool bothtoggle = false;
    public GameObject canvasobject;

    // Start is called before the first frame update
    void Start()
    {
       wavesound.playOnAwake = false;
       wavesound.loop = true;

       wavevideo.playOnAwake = false;
       wavevideo.isLooping = true;


       playboth.onClick.AddListener(()=>{
           if(bothtoggle == false){
               wavesound.Play();
               bothtoggle = true;
               wavevideo.Play();
               bothtoggle = true;

               canvasobject.SetActive(false);
                Invoke("newVoid", 53f);

           }else{
               //wavesound.Stop();
               wavesound.Pause();
               wavesound.time = 0;
               bothtoggle = false;
               wavevideo.Pause();
               wavevideo.frame = 0;
               bothtoggle = false;
           }
       });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void newVoid(){
       SceneManager.LoadScene("tut_1");
     
        }
}