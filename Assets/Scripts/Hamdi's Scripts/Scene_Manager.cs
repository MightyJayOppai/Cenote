using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    private int mainMenu_Scene;
    private int game_Scene;
    private int instructions_Scene;
    private int credits_Scene;
    private int secondPuzzle_Scene;

    public GolemBehaviorTree golem;

    public GameObject golemComandPanel;

    public GameObject player;

    public Static staticObj;

    void Start ()
    {
        mainMenu_Scene = 0;
        game_Scene = 1;
        instructions_Scene = 2;
        credits_Scene = 3;
        secondPuzzle_Scene = 4;

        golemComandPanel.SetActive(false);

        GameObject golemModel = GameObject.FindGameObjectWithTag("Golem");
        golem = golemModel.GetComponent<GolemBehaviorTree>();

        GameObject staticObgHolder = GameObject.FindGameObjectWithTag("Static");
        staticObj = staticObgHolder.GetComponent<Static>();

        if (staticObj.doneFromSecondPuzzle == true)
        {
            //player.transform.position = new Vector3(0, 0, 0);
            print("done from puzzle room");
        }
    }
	
	void Update ()
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

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenu_Scene);
        Time.timeScale = 1;
    }

    public void Instructions()
    {
        SceneManager.LoadScene(instructions_Scene);
        Time.timeScale = 1;
    }

    public void Credits()
    {
        SceneManager.LoadScene(credits_Scene);
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Game()
    {
        SceneManager.LoadScene(game_Scene);
        Time.timeScale = 1;
    }

    public void SecondPuzzle()
    {
        SceneManager.LoadScene(secondPuzzle_Scene);
        Time.timeScale = 1;
    }
}
