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
    }
}
