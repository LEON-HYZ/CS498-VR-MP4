using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public static bool GameIsUnpaused = true;
    public GameObject pauseMenuUI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.GetDown(OVRInput.RawButton.Start) ||   Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (GameIsPaused && OVRInput.GetDown(OVRInput.RawButton.A))
        {
            Resume();
        }
        if (GameIsPaused && OVRInput.GetDown(OVRInput.RawButton.X))
        {
            Restart();
        }
        if (GameIsPaused && OVRInput.GetDown(OVRInput.RawButton.B))
        {
            LoadMenu();
        }
        if (GameIsPaused && OVRInput.GetDown(OVRInput.RawButton.Y))
        {
            QuitGame();
        }



    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    public void Restart()
    {
        Debug.Log("Restarting Game...");
        Menu.isTutorial = false;
        Score.scoreValue = 0;
        Time.timeScale = 1f;
        //pcoll.isTrigger = true;
        SceneManager.LoadScene("CS498HW4");
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }
    public void LoadMenu()
    {
        Debug.Log("Loading Menu...");
        //Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quiting Game...");
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
