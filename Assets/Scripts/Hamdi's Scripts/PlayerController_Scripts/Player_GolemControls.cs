using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_GolemControls : MonoBehaviour
{
    public GameObject golemComandPanel;

    public GameObject companionComandPanel;

    public GolemBehaviorTree golem;

    public bool inSecondScene;

    public Scene currentScene;

    void Start ()
    {
        GameObject golemModel = GameObject.FindGameObjectWithTag("Golem");
        golem = golemModel.GetComponent<GolemBehaviorTree>();

        golemComandPanel.SetActive(false);
        companionComandPanel.SetActive(true);
    }

    void Update()
    {
            if (golem.controlledByPlayer == false && Input.GetKeyDown(KeyCode.G))
            {
                golem.controlledByPlayer = true;
            }
            if (golem.controlledByPlayer == true)
            {
                companionComandPanel.SetActive(false);
                golemComandPanel.SetActive(true);
            }
            else if (golem.controlledByPlayer == false)
            {
                companionComandPanel.SetActive(true);
                golemComandPanel.SetActive(false);
            }
    }
}
