using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public void PointerEnter()
    {
        transform.localScale = new Vector2(1.3f, 1.8f);
    }

    public void PointerExit()
    {
        transform.localScale = new Vector2(1,1.5f);
    }
}
