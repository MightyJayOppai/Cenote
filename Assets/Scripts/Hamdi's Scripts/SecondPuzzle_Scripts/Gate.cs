using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gate : MonoBehaviour
{
    int thirdPuzzleScene;

    public GameObject gate;
    private float speed;
    private Vector3 targetPosition;
    public bool gateShouldMove;

    public Static staticObj;

    private AudioSource aSource;

    private void Start()
    {
        GameObject staticObgHolder = GameObject.FindGameObjectWithTag("Static");
        staticObj = staticObgHolder.GetComponent<Static>();

        thirdPuzzleScene = 1;

        aSource = GetComponent<AudioSource>();

        speed = 1f;
        targetPosition = gate.transform.position + new Vector3(0, -5, 0);
    }

    private void Update()
    {
        if (gateShouldMove == true)
        {
            float step = speed * Time.deltaTime;
            gate.transform.position = Vector3.MoveTowards(gate.transform.position, targetPosition, step);
            aSource.Play();
            Invoke("StopSound", 4f);
        }
    }

    void StopSound()
    {
        aSource.Pause();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            staticObj.doneFromSecondPuzzle = true;
            SceneManager.LoadScene(thirdPuzzleScene);
            Time.timeScale = 1;
        }
    }
}
