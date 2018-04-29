using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatePanel : MonoBehaviour {

    public string CurOrder = "869";
    public string input;
    public bool OnTrigger;
    public bool GateIsOpened;
    public bool GatePanelScreen;
    public Transform GateHinge;

    void OnTriggerEnter(Collider other)
    {
        OnTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        OnTrigger = false;
        GatePanelScreen = false;
        Cursor.lockState = CursorLockMode.Locked;
        input = "";
    }

    void OnGUI()
    {
        if (OnTrigger)
        {
            GUI.Box(new Rect(50, 50, 200, 25), "Press E To Open Panel");

            if(Input.GetKeyDown(KeyCode.E))
            {
                GatePanelScreen = true;
                OnTrigger = false;
                Cursor.lockState = CursorLockMode.None;
            }
        }

        if(GatePanelScreen)
        {
            GUI.Box(new Rect(0, 0, 320, 455), "");
            GUI.Box(new Rect(5, 5, 310, 25), input);

            if(GUI.Button(new Rect(5, 35, 100, 100), "1"))
            {  
                input = input + "1";
            }
            if (GUI.Button(new Rect(110, 35, 100, 100), "2"))
            {
                input = input + "2";
            }
            if (GUI.Button(new Rect(215, 35, 100, 100), "3"))
            {
                input = input + "3";
            }
            if (GUI.Button(new Rect(5, 140, 100, 100), "4"))
            {
                input = input + "4";
            }
            if (GUI.Button(new Rect(110, 140, 100, 100), "5"))
            {
                input = input + "5";
            }
            if (GUI.Button(new Rect(215, 140, 100, 100), "6"))
            {
                input = input + "6";
            }
            if (GUI.Button(new Rect(5, 245, 100, 100), "7"))
            {
                input = input + "7";
            }
            if (GUI.Button(new Rect(110, 245, 100, 100), "8"))
            {
                input = input + "8";
            }
            if (GUI.Button(new Rect(215, 245, 100, 100), "9"))
            {
                input = input + "9";
            }
        }
    }

    void Start ()
    {
		
	}
	
	
	void Update ()
    {
		if(input == CurOrder)
        {
            GateIsOpened = true;
        }

        if (GateIsOpened)
        {
            var newRotation = Quaternion.RotateTowards(GateHinge.rotation, Quaternion.Euler(0.0f, -38.577f, -100f), Time.deltaTime * 50);
            GateHinge.rotation = newRotation;
        }
	}
}
