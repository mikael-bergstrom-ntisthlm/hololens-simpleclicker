using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class ColorChanger : MonoBehaviour, IInputClickHandler
{
    Color[] colors = { Color.blue, Color.green, Color.red };


    public void OnInputClicked(InputClickedEventData eventData)
    {
        GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
    }
}
