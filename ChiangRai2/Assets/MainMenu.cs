using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void BackMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Loadingtolevel 1");
    }
}
