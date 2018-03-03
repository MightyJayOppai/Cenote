using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePickUp : MonoBehaviour {

    public GameObject NoteScreen;
    public Collider Col;
    public GameObject NotePickUpText;

	void Start ()
    {
        NoteScreen.SetActive(false);
        NotePickUpText.SetActive(false);
	}
	
	
	void Update ()
    {
		if(Col!= null && Input.GetKeyDown(KeyCode.E))
        {
            NoteScreen.SetActive(!NoteScreen.activeSelf);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Col = other;
            NotePickUpText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            Col = null;
            NoteScreen.SetActive(false);
            NotePickUpText.SetActive(false);
        }
    }
}
