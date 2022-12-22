using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Loadtolevel : MonoBehaviour
{
    public bool isStart;
    public Slider Loading2;
    public float Score;
    public float currentVelocity;
    public float currentScore;

    public void Update()
    {
        isStart = true;
        if (isStart)
        {
            Loading2.value = currentScore;
            currentScore = Mathf.SmoothDamp(Loading2.value, Score, ref currentVelocity, 100 * Time.deltaTime + 0.7f);
            



        }
        if (currentScore >= 99.8f)
        {
            SceneManager.LoadScene("LevelSelect");
        }


    }
}
