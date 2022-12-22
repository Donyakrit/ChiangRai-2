using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class EscFn : MonoBehaviour
{
    public GameObject screen;
    // Start is called before the first frame update

  
    public void Pausethegame (InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Pause  " + context.phase);
            screen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
