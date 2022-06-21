using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorChange : MonoBehaviour
{
    public GameObject ButtonColor;
    
    public void ButtonColorChnage()
    {
        gameObject.GetComponent<Image>().color = Random.ColorHSV();
    }
}
