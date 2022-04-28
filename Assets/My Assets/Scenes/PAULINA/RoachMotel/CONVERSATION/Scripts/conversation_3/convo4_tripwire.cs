using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class convo4_tripwire : MonoBehaviour
{

    public GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
        {
           Debug.Log("tagged"); //collision.gameObject.SendMessage("ApplyDamage", 10);
           //roger.GetComponent<Enemy>().hp = 0f;
           //roger.GetComponent<Enemy>().hp_max = 0f;
           // Destroy(roger);
            SceneManager.LoadScene("RB_cutscene");
          
        }
}
