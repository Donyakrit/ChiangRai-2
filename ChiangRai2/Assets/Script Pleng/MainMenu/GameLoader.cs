using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoader : MonoBehaviour
{
    public void GameScene()
    {
        VarHolder.Map1Clear = false;
        VarHolder.Map2Clear = false;
        VarHolder.Map3Clear = false;
        VarHolder.Map4Clear = false;
        SceneManager.LoadScene("OpenScene");
    }
}