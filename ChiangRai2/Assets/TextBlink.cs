using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBlink : MonoBehaviour
{
   
    public float blinkFadeInTime = 0.5f;
    public float blinkStayInTime = 0.8f;
    public float blinkFadeOutTime = 0.7f;
    private float _timeChecker = 0f;
    private Color _color;
    public Text _ibl;
    // Start is called before the first frame update
    void Start()
    {
       
        _color = _ibl.color;
    }

    // Update is called once per frame
    void Update()
    {
        _timeChecker += Time.deltaTime; 

        if(_timeChecker < blinkFadeInTime)
        {
            _ibl.color = new Color(_color.r, _color.g, _color.b, _timeChecker / blinkFadeInTime);
        }
        else if (_timeChecker < blinkFadeInTime + blinkStayInTime)
        {
            _ibl.color = new Color(_color.r, _color.g, _color.b, 1);
        }
        else if (_timeChecker < blinkFadeInTime + blinkStayInTime + blinkFadeOutTime)
        {
            _ibl.color = new Color(_color.r, _color.g, _color.b, (_timeChecker - (blinkFadeInTime+ blinkStayInTime) / blinkFadeOutTime));
        }
        else
        {
            _timeChecker = 0;
        }
    }
}
