using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class To2ndRoom : MonoBehaviour
{
    int secondPuzzleRoom;

    public Static staticObj;

    void Start ()
    {
        GameObject staticObgHolder = GameObject.FindGameObjectWithTag("Static");
        staticObj = staticObgHolder.GetComponent<Static>();

        secondPuzzleRoom = 4;
	}


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && (staticObj.doneFromSecondPuzzle == false))
        {
            SceneManager.LoadScene(secondPuzzleRoom);
            Time.timeScale = 1;
        }
    }
}
