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

	void Start ()
    {
        mainMenu_Scene = 0;
        game_Scene = 1;
        instructions_Scene = 2;
        credits_Scene = 3;
        secondPuzzle_Scene = 4;
	}
	
	void Update ()
    {
		//pause Menu code
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
