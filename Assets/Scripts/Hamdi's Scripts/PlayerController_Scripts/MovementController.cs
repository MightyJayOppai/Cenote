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
    /*public Collider panelCol;
    public Collider lever1Col;
    public Collider lever2Col;
    public Collider lever3Col;*/

    public GolemBehaviorTree golem;

    /*public GameObject[] levers;
    private bool hitLeverOne;
    private bool hitLeverTwo;
    private bool hitLeverThree;
    private Animator levelThreeDoorAnim;*/

    void Start ()
    {
        GameObject golemModel = GameObject.FindGameObjectWithTag("Golem");
        golem = golemModel.GetComponent<GolemBehaviorTree>();

        playerWalkSpeed = 2.0f;
        playerRunSpeed = 5.0f;
        playerSpeed = playerWalkSpeed;

        rB = GetComponentInChildren<Rigidbody>();
        cR = GetComponentInChildren<Collider>();

        /*for (int i = 0; i < levers.Length; i++)
        {
            levers[i].SetActive(false);
        }*/

        //levelThreeDoorAnim = GameObject.FindGameObjectWithTag("ThirdRoomDoor").GetComponent<Animator>();

        // to lock the mouse to the game
        //Cursor.lockState = CursorLockMode.Locked;
    }

	void FixedUpdate ()
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

        /*if (panelCol != null && Input.GetKey(KeyCode.E))
        {
            for (int i = 0; i < levers.Length; i++)
            {
                levers[i].SetActive(true);
            }
        }

        if (hitLeverThree)
            levelThreeDoorAnim.SetBool("isMoving", true);
        else
            levelThreeDoorAnim.SetBool("isMoving", false);

        if (lever1Col != null && Input.GetKey(KeyCode.E))
        {
            hitLeverOne = true;
        }

        if (lever2Col != null && Input.GetKey(KeyCode.E) && hitLeverOne)
        {
            hitLeverTwo = true;
        }

        if (lever3Col != null && Input.GetKey(KeyCode.E) && hitLeverOne && hitLeverTwo)
        {
            hitLeverThree = true;
        }

        //to cancel the mouse lock
        /*if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }*/
    }

    /*void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Panel")
        {
            panelCol = other.collider;
        }

        if (other.gameObject.tag == "Lever1")
        {
            lever1Col = other.collider;
        }

        if (other.gameObject.tag == "Lever2")
        {
            lever2Col = other.collider;
        }

        if (other.gameObject.tag == "Lever3")
        {
            lever3Col = other.collider;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Panel")
        {
            panelCol = null;
        }

        if (other.gameObject.tag == "Lever1")
        {
            lever1Col = null;
        }

        if (other.gameObject.tag == "Lever2")
        {
            lever2Col = null;
        }

        if (other.gameObject.tag == "Lever3")
        {
            lever3Col = null;
        }
    }*/
}