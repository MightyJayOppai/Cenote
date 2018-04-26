using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePickUp : MonoBehaviour {

    public GameObject NoteScreen;
    public Collider Col;
    public GameObject NotePickUpText;

    private AudioSource aud;
    public AudioClip audNote;

	void Start ()
    {
        NoteScreen.SetActive(false);
        NotePickUpText.SetActive(false);

        aud = GetComponent<AudioSource>();
	}
	
	
	void Update ()
    {
		if(Col!= null && Input.GetKeyDown(KeyCode.E))
        {
            NoteScreen.SetActive(!NoteScreen.activeSelf);
            if (NoteScreen.activeSelf)
            {
                aud.PlayOneShot(audNote, 0.2f);
            }
        }
	}

    void OnTriggerEnter(Collider other)
    {
        //To display the NoteScreen once the player enters the collider
        if (other.tag == "Player")
        {
            Col = other;
            NotePickUpText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        //To remove the NoteScreen once the player moves away from the collider
        if (other.tag == "Player")
        {
            Col = null;
            NoteScreen.SetActive(false);
            NotePickUpText.SetActive(false);
        }
    }
}
