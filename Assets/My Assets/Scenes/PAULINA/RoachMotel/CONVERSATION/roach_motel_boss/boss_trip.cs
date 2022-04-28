using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace IndieMarc.TopDown
{
public class boss_trip : MonoBehaviour
{
    public GameObject roger;
    public GameObject player;

    Enemy a;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
 // Destroy (gameObject); // destroy the projectile anyway
    }

   void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "boss")
        {
           Debug.Log("tagged"); //collision.gameObject.SendMessage("ApplyDamage", 10);
           //roger.GetComponent<Enemy>().hp = 0f;
           //roger.GetComponent<Enemy>().hp_max = 0f;
           // Destroy(roger);
            SceneManager.LoadScene("RB_Death");
          
        }
        
        
  }
           /* a=GameObject.FindGameObjectWithTag("Boss").GetComponent<Enemy>();
        a.Kill(gameObject);*/
           //roger.GetComponent<IsDead>().enabled = true;
        
    }}
                    
              
            
    

