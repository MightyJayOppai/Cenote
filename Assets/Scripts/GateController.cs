using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour {

    public GameObject Gate;
    public bool gateIsOpening;
    public GameObject GateButtonText;

	void Start ()
    {
        GateButtonText.SetActive(false);
	}
	
	
	void Update ()
    {
        //if the boolian is true, open the gate
        if (gateIsOpening == true)
        {
            Gate.transform.Translate(Vector3.up * Time.deltaTime * 2);
        }

        //if the position of the gate is less than 10f, stop the gate
        if (Gate.transform.position.y > 10f)
        {
            gateIsOpening = false;
        }

        // Once the button is clicked, the gate will open
        if (Input.GetKeyDown(KeyCode.E))
        {
            gateIsOpening = true;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        //To display the GateText
        if (other.tag == "Player")
        {
            GateButtonText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        //To remove the GateText 
        if (other.tag == "Player")
        {
            GateButtonText.SetActive(false);
        }
    }
}
