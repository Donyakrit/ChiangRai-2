using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadmap1()
    {
        SceneManager.LoadScene("Loadingtomap1");
    }

    public void loadmap2()
    {
        SceneManager.LoadScene("Loadingtomap2");
    }

    public void loadmap3()
    {
        SceneManager.LoadScene("Loadingtomap3");
    }

    public void loadmap4()
    {
        SceneManager.LoadScene("Loadingtomap4");
    }
}
