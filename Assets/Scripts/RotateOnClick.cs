using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class RotateOnClick : MonoBehaviour, IInputClickHandler {

    bool isRotating = false;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        isRotating = !isRotating;
    }
	
	// Update is called once per frame
	void Update () {
        if (isRotating)
        {
            transform.Rotate(Vector3.up, 45 * Time.deltaTime);
        }
	}
}
