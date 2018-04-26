using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToEndCredits : MonoBehaviour {

    int Credits;

    public Static staticObj;

	void Start ()
    {
        GameObject staticObgHolder = GameObject.FindGameObjectWithTag("Static");
        staticObj = staticObgHolder.GetComponent<Static>();

        Credits = 3;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && (staticObj.doneFromThirdPuzzle == false))
        {
            SceneManager.LoadScene(Credits);
            Time.timeScale = 1;
        }
    }
}
