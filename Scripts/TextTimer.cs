 using UnityEngine;
 using System.Collections;
  
 public class TextTimer : MonoBehaviour
 {
     public float time = 11; //Seconds to read the text
     public GameObject text;
     public GameObject btext;
     public GameObject ltext;
     public GameObject button;
 
     float TmStart;
     float TmLen=9f;
 
     // Use this for initialization
     void Start () {
         TmStart=Time.time;
     }
     
     // Update is called once per frame
     void Update () {
         if(Time.time>TmStart + TmLen) 
         {
 
             text.SetActive (false);
             btext.SetActive (true);
             ltext.SetActive(true);
             button.SetActive(true);

         }
     }

    
 }