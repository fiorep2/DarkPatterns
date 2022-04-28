using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_play : MonoBehaviour
{
  
    public AudioSource buttonsound;
   
    void Start () {
      
   
       
    }
   
   public void playSoundEffect(){
       buttonsound.Play();
   }    
}