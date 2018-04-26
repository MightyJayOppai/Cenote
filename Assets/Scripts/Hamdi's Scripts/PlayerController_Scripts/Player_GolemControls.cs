using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_GolemControls : MonoBehaviour
{
    public GameObject golemComandPanel;

    public GolemBehaviorTree golem;

    public bool inSecondScene;

    public Scene currentScene;

    void Start ()
    {
        GameObject golemModel = GameObject.FindGameObjectWithTag("Golem");
        golem = golemModel.GetComponent<GolemBehaviorTree>();

        golemComandPanel.SetActive(false);

        if (currentScene.name == "2nd Puzzle Room")
        {
            inSecondScene = true;
        }
    }

    void Update()
    {
        if (inSecondScene == true)
        {
            if (golem.controlledByPlayer == true)
            {
                golemComandPanel.SetActive(true);
            }
            else if (golem.controlledByPlayer == false)
            {
                golemComandPanel.SetActive(false);
            }
        }
    }
}
