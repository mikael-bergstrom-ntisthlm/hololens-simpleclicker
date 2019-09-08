using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;


public class InputHandler : MonoBehaviour, IInputClickHandler
{
    public void OnInputClicked(InputClickedEventData eventData)
    {
        print("heeey");
    }

    void Start () {

        InputManager.Instance.PushModalInputHandler(gameObject);
        InputManager.Instance.AddGlobalListener()

	}

}
