using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeviceSelect : MonoBehaviour
{
    public static bool SolarCorrect = false;
    public static bool WindCorrect = false;
    public static bool WaterCorrect = false;
    public static bool ThermoCorrect = false;
    public GameObject IncorrctSolarCanvas;
    public GameObject IncorrctWindCanvas;
    public GameObject IncorrctWaterCanvas;
    public GameObject IncorrctThermoCanvas;
    public GameObject MainCamera;
    public GameObject ShowCamera;
    public GameObject DeviceToSetActive;
    public GameObject DeviceCanva;
    bool StartCount;
    float CurrentTime;
    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = 3f;
        StartCount = false;
        DeviceToSetActive.SetActive(false);
        IncorrctSolarCanvas.SetActive(false);
        IncorrctWindCanvas.SetActive(false);
        IncorrctWaterCanvas.SetActive(false);
        IncorrctThermoCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(StartCount)
        {
            CurrentTime -= Time.deltaTime;
            Debug.Log(CurrentTime);
        }

        if(CurrentTime <= 0f)
        {
            SceneManager.LoadScene("LevelSelect");
        }
    }

    void Correct()
    {
        QuestUpdater.QuestText = "Congrats!";
        DeviceCanva.SetActive(false);
        DeviceToSetActive.SetActive(true);
        MainCamera.SetActive(false);
        ShowCamera.SetActive(true);
        StartCount = true;
    }

    public void SelectSolar()
    {
        if(SolarCorrect)
        {
            VarHolder.Map1Clear = true;
            Correct();
        }
        else
        {
            IncorrctSolarCanvas.SetActive(true);
        }
    }

    public void SelectWind()
    {
        if (WindCorrect)
        {
            VarHolder.Map3Clear = true;
            Correct();
        }
        else
        {
            IncorrctWindCanvas.SetActive(true);
        }
    }

    public void SelectWater()
    {
        if (WaterCorrect)
        {
            VarHolder.Map2Clear = true;
            Correct();
        }
        else
        {
            IncorrctWaterCanvas.SetActive(true);
        }
    }

    public void SelectThermo()
    {
        if (ThermoCorrect)
        {
            VarHolder.Map4Clear = true;
            Correct();
        }
        else
        {
            IncorrctThermoCanvas.SetActive(true);
        }
    }
}
