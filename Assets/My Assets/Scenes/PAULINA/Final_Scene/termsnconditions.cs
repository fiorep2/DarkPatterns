using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class termsnconditions : MonoBehaviour
{
    public GameObject canvasObject;
    public GameObject Convo;
    int n;
   public void OnButtonPress(){
      n++;
      Debug.Log("Button clicked " + n + " times.");
      canvasObject.SetActive(false);
      Convo.SetActive(true);
   }
}
