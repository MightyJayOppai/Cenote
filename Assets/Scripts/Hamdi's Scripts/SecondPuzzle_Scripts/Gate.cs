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

    private void Start()
    {
        thirdPuzzleScene = 5;

        speed = 1f;
        targetPosition = gate.transform.position + new Vector3(0, -5, 0);
    }

    private void Update()
    {
        if (gateShouldMove == true)
        {
            float step = speed * Time.deltaTime;
            gate.transform.position = Vector3.MoveTowards(gate.transform.position, targetPosition, step);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            //SceneManager.doneFromRoom2 = true;
            SceneManager.LoadScene(thirdPuzzleScene);
            Time.timeScale = 1;
        }
    }
}
