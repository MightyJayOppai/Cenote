using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatePanel : MonoBehaviour {

    public string CurOrder = "abc";
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
            }
        }

        if(GatePanelScreen)
        {
            GUI.Box(new Rect(0, 0, 320, 455), "");
            GUI.Box(new Rect(5, 5, 310, 25), input);

            if(GUI.Button(new Rect(5, 35, 100, 100), "a"))
            {  
                input = input + "a";
            }
            if (GUI.Button(new Rect(110, 35, 100, 100), "b"))
            {
                input = input + "b";
            }
            if (GUI.Button(new Rect(215, 35, 100, 100), "c"))
            {
                input = input + "c";
            }
            if (GUI.Button(new Rect(5, 140, 100, 100), "d"))
            {
                input = input + "d";
            }
            if (GUI.Button(new Rect(110, 140, 100, 100), "e"))
            {
                input = input + "e";
            }
            if (GUI.Button(new Rect(215, 140, 100, 100), "f"))
            {
                input = input + "f";
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
            var newRotation = Quaternion.RotateTowards(GateHinge.rotation, Quaternion.Euler(0.0f, 180.0f, 0.0f), Time.deltaTime * 25);
            GateHinge.rotation = newRotation;
        }
	}
}
