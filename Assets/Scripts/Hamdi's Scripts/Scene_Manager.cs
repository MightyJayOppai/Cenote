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

    public GameObject player;

    public Static staticObj;

    public GameObject pause_Menu;
    public bool paused;
    public GameObject instructions_Panel;

    void Start ()
    {
        pause_Menu.SetActive(false);
        instructions_Panel.SetActive(false);

        paused = false;

        mainMenu_Scene = 0;
        game_Scene = 1;
        instructions_Scene = 2;
        credits_Scene = 3;
        secondPuzzle_Scene = 4;

        player = GameObject.FindGameObjectWithTag("Player");

        GameObject staticObgHolder = GameObject.FindGameObjectWithTag("Static");
        staticObj = staticObgHolder.GetComponent<Static>();

        if (staticObj.doneFromSecondPuzzle == true)
        {
            player.transform.position = new Vector3(-11.17f, 2.684f, -15.37f);
        }

    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;

            if (paused == true)
            {
                pause_Menu.SetActive(true);
                Time.timeScale = 0;
            }
            else if (paused == false)
            {
                pause_Menu.SetActive(false);
                Time.timeScale = 1;
            }
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

    public void Resume()
    {
        pause_Menu.SetActive(false);
        paused = false;
        Time.timeScale = 1;
    }

    public void InGameInstructions()
    {
        pause_Menu.SetActive(false);
        instructions_Panel.SetActive(true);
    }

    public void BackToPauseMenu()
    {
        instructions_Panel.SetActive(false);
        pause_Menu.SetActive(true);
    }
}
