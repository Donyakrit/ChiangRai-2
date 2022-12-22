using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class EscFn : MonoBehaviour
{
    public GameObject screen;
    public static bool Pause = false;
    // Start is called before the first frame update


    public void Pausethegame(InputAction.CallbackContext context)
    {
        if (Pause == false)
        {

            if (context.performed)
            {
                Debug.Log("Pause  " + context.phase);
                screen.SetActive(true);
                Time.timeScale = 0;
                Pause = true;

            }
        }
        else
        {
            if (context.performed)
            {
                Debug.Log("Goback  " + context.phase);
                screen.SetActive(false);
                Time.timeScale = 1;
                EscFn.Pause = false;
            }
        }










    }
}

