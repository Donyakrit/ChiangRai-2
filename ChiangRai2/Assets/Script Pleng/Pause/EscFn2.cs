using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.InputSystem;

public class EscFn2 : MonoBehaviour
{
    
    public GameObject screen;
    public void BackGame(InputAction.CallbackContext context)
    {
        if (EscFn.Pause == true)
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
