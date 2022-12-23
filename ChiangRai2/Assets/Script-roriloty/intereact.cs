using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class intereact : MonoBehaviour
{

    public bool isinside;
    public bool isimportance;
    public string ImportanceTask;
    public string DeviceToBring;
    public GameObject Ebutton;
    public GameObject Dialog_Box;
    public TMP_Text Dialog;
    public TMP_Text Name_Box;
    public string Name;
    public bool inintereact;
    public int index;
    public string[] line = { "Hello World" , "Bye" };
    public AudioSource dialogAudio;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        inintereact = false;
        Ebutton.SetActive(false);
        Dialog_Box.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && isinside)
        {
            dialogAudio.Play();
            if (inintereact)
            {
                GotoNextLine();
            }
            else
            {
                Gotointereact();
            }
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        isinside = true;
        Ebutton.SetActive(true);
    }

    private void OnTriggerExit(Collider collider)
    {
        isinside = false;
        Ebutton.SetActive(false);
        Exitintereact();
    }

    void Gotointereact()
    {
        index = 0;
        inintereact = true;
        Ebutton.SetActive(false);
        Dialog_Box.SetActive(true);
        Dialog.text = line[0];
        Name_Box.text = Name;
    }

    void Exitintereact()
    {
        inintereact = false;
        if (isinside)
        {
            Ebutton.SetActive(true);
        }
        else
        {
            Ebutton.SetActive(false);
        }
        Dialog_Box.SetActive(false);
    }

    void GotoNextLine()
    {
        index++;
        if(line.Length > index)
        {
            Dialog.text = line[index];
            
        }
        else
        {
            if(isimportance)
            {
                Dosomething();
            }
            Exitintereact();
        }
    }

    void Dosomething()
    {
        QuestUpdater.QuestText = ImportanceTask;
        QuestUpdater.DeviceRequire = DeviceToBring;
    }
}
