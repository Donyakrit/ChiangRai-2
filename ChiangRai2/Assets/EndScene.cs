using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    // Start is called before the first frame update

    public float currentTime = 42f;

    public void Update()
    {
        currentTime -= Time.deltaTime;
        //if(currentTime < 0)
        //{

        //SceneManager.LoadScene("Loading");

        //}
        if (currentTime < 0)
        {
            SceneManager.LoadScene("Loadtomain");

        }
    }
}
