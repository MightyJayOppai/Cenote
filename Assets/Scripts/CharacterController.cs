using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float playerSpeed = 10.0f;

	void Start ()
    {
        // to lock the mouse to the game
        //Cursor.lockState = CursorLockMode.Locked;
	}
	

	void Update ()
    {
        float fAndB = Input.GetAxis("Vertical") * playerSpeed;
        float rAndL = Input.GetAxis("Horizontal") * playerSpeed;

        //to make character to move smothely
        fAndB *= Time.deltaTime;
        rAndL *= Time.deltaTime;

        //
        transform.Translate(rAndL, 0, fAndB);

        //to cancel the mouse lock
        /*if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }*/
	}
}
