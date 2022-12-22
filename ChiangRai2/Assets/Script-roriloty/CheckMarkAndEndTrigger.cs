using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMarkAndEndTrigger : MonoBehaviour
{
    public GameObject Check1;
    public GameObject Check2;
    public GameObject Check3;
    public GameObject Check4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(VarHolder.Map1Clear)
        {
            Check1.SetActive(true);
        }
        else
        {
            Check1.SetActive(false);
        }

        if (VarHolder.Map2Clear)
        {
            Check2.SetActive(true);
        }
        else
        {
            Check2.SetActive(false);
        }

        if (VarHolder.Map3Clear)
        {
            Check3.SetActive(true);
        }
        else
        {
            Check3.SetActive(false);
        }

        if (VarHolder.Map4Clear)
        {
            Check4.SetActive(true);
        }
        else
        {
            Check4.SetActive(false);
        }
    }
}
