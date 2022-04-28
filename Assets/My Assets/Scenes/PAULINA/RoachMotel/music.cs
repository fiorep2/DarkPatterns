 using UnityEngine;
 using System.Collections;
 using UnityEngine.SceneManagement;
 
 public class music : MonoBehaviour {
 
     void Awake ()
     {
         GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
         if (objs.Length > 1)
             Destroy(this.gameObject);
 
         DontDestroyOnLoad(this.gameObject);
 
     }
 
     void Update()
     {if (SceneManager.GetActiveScene().name == "CUTSCENE_1")
         {
             Destroy(this.gameObject);
         }
         if (SceneManager.GetActiveScene().name == "conversation_3")
         {
             Destroy(this.gameObject);
         }
     }
 }
