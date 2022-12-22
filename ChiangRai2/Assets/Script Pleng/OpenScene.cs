using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using TMPro;

public class OpenScene : MonoBehaviour
{
   
    public float currentTime = 36f;
    public GameObject button;
    public GameObject text;

    public void Start()
    {
        button.SetActive(false);
        text.SetActive(false);
    }
    // Start is called before the first frame update
    public void Update()
    {
        currentTime -= Time.deltaTime;
        //if(currentTime < 0)
        //{
           
               //SceneManager.LoadScene("Loading");
            
        //}
        if (currentTime <= 0)
        {
            button.SetActive(true);
            text.SetActive(true);

            

         }
    }

    

    public void ExitControl()
    {
        SceneManager.LoadScene("Loading");

    }



}
