using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float playerSpeed;
    public float playerWalkSpeed;
    public float playerRunSpeed;

    public float fAndB;
    public float rAndL;

    public Collider cR;
    public Rigidbody rB;

    public GolemBehaviorTree golem;


    void Start ()
    {
        GameObject golemModel = GameObject.FindGameObjectWithTag("Golem");
        golem = golemModel.GetComponent<GolemBehaviorTree>();

        playerWalkSpeed = 1.0f;
        playerRunSpeed = 10.0f;
        playerSpeed = playerWalkSpeed;

        rB = GetComponentInChildren<Rigidbody>();
        cR = GetComponentInChildren<Collider>();

        // to lock the mouse to the game
        //Cursor.lockState = CursorLockMode.Locked;
    }

	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerSpeed = playerRunSpeed;
        }
        else
        {
            playerSpeed = playerWalkSpeed;
        }

        fAndB = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        rAndL = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;

        //the function that moves the player
        transform.Translate(rAndL, 0, fAndB);

        if (Input.GetKeyDown(KeyCode.G))
        {
            golem.shouldGoToPlayer = true;
        }

        //to cancel the mouse lock
        /*if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }*/
    }
}