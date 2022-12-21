using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoadingBar : MonoBehaviour
{
    public bool isStart;
    public Slider Loading2;
    public float Score;
    public float currentVelocity = 0f;
    public float currentScore;

    public void Update()
    {
        if (isStart)
        {
            currentScore = Mathf.SmoothDamp(Loading2.value, Score, ref currentVelocity, 100 * Time.deltaTime + 0.7f);
            Loading2.value = currentScore;



        }
        if (currentScore >= 99.8f)
        {
            SceneManager.LoadScene("Level1");
        }


    }
}



    
    
