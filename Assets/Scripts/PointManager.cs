using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PointManager : MonoBehaviour {

    private TextMeshPro textComponent;
    private int points = 0;
    

	// Use this for initialization
	void Start () {
        textComponent = GetComponent<TextMeshPro>();
        ResetPoints();
	}

    public void AddPoints()
    {
        AddPoints(1);
    }

    public void AddPoints(int amount)
    {
        points++;
        UpdateDisplay();
    }

    public void ResetPoints()
    {
        points = 0;
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        textComponent.text = points.ToString("00");
    }


}
