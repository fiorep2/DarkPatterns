using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Key script
/// Author: Indie Marc (Marc-Antoine Desbiens)
/// </summary>

namespace IndieMarc.TopDown
{

    public class Key : MonoBehaviour
    {
        public int key_index = 0; //Which door it opens

        private string unique_id;

        void Start()
        {
            unique_id = GetComponent<UniqueID>().unique_id;

            if (PlayerData.Get().HasUniqueID(unique_id))
                Destroy(gameObject);
        }

        private void Update()
        {
            
        }

        public void TakeKey() {
            PlayerData.Get().AddKey(key_index);
            PlayerData.Get().SetUniqueID(unique_id, 1);
            Destroy(gameObject);
        }
        
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.GetComponent<PlayerCharacter>())
            {
                TakeKey();
                //SceneManager.LoadScene("RB_Death");
            }
            if (collision.gameObject.tag == "player1")
            {
                //TakeKey();
                SceneManager.LoadScene("RB_Death");
            }
            if (collision.gameObject.tag == "player2")
            {
                //TakeKey();
                SceneManager.LoadScene("intro_CutScene");
            }
        }
    }

}