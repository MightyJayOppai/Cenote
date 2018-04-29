using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToEndCredits : MonoBehaviour
{

    int Credits;

    public Static staticObj;

    public GameObject player;

    private float speed;

    Vector3 upPosition;

    public bool playerShouldClimb;

    void Start ()
    {
        GameObject staticObgHolder = GameObject.FindGameObjectWithTag("Static");
        staticObj = staticObgHolder.GetComponent<Static>();

        player = GameObject.FindGameObjectWithTag("Player");

        speed = 0.5f;

        Credits = 3;
    }

    private void Update()
    {
        if (playerShouldClimb == true)
        {
            float step = speed * Time.deltaTime;
            player.transform.position = Vector3.MoveTowards(player.transform.position, upPosition, step);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && (staticObj.doneFromThirdPuzzle == true))
        {
            staticObj.controlsDisabled = true;

            playerShouldClimb = true;

            upPosition = player.transform.position + new Vector3(0f, 10f, 0f);

            staticObj.disablePlayerRigidBody = true;

            Invoke("ChangeScene", 6f);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(Credits);
        Time.timeScale = 1;
    }
}
