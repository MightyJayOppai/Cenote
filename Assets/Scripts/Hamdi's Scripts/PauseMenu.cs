using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pause_Menu;
    public bool paused;

    private int main_Menu;

    public GameObject instructions_Panel;

	void Start ()
    {
        pause_Menu.SetActive(false);
        instructions_Panel.SetActive(false);

        paused = false;

        main_Menu = 0;
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;

            if (paused = true)
            {
                pause_Menu.SetActive(true);
                Time.timeScale = 0;
            }
            else if (paused = false)
            {
                pause_Menu.SetActive(false);
                Time.timeScale = 1;
            }
        }
	}

    public void Resume()
    {
        pause_Menu.SetActive(false);
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(main_Menu);
    }

    public void instructions()
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
