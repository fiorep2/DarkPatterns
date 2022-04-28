using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class readmore : MonoBehaviour
{
    public GameObject readmoreimg;
    int n;
   public void OnButtonPress(){
      n++;
      Debug.Log("Button clicked " + n + " times.");
      readmoreimg.SetActive(true);
   }
}
