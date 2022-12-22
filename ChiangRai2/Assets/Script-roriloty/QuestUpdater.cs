using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestUpdater : MonoBehaviour
{
    public static string QuestText = "Find Clue";
    public static string DeviceRequire = "Solar Cell";
    public TMP_Text QuestTextObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        QuestTextObject.text = QuestText;
        if(DeviceRequire == "Solar Cell")
        {
            DeviceSelect.SolarCorrect = true;
        }
        else
        {
            DeviceSelect.SolarCorrect = false;
        }

        if (DeviceRequire == "Water Turbine")
        {
            DeviceSelect.WaterCorrect = true;
        }
        else
        {
            DeviceSelect.WaterCorrect = false;
        }

        if (DeviceRequire == "Wind Turbine")
        {
            DeviceSelect.WindCorrect = true;
        }
        else
        {
            DeviceSelect.WindCorrect = false;
        }

        if (DeviceRequire == "Geothermal")
        {
            DeviceSelect.ThermoCorrect = true;
        }
        else
        {
            DeviceSelect.ThermoCorrect = false;
        }
    }
}
