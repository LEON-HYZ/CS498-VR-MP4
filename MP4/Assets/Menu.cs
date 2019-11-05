using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public static bool isTutorial = false;
    // Use this for initialization

	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.GetDown(OVRInput.RawButton.Y))
        {
            LoadGame();
        }
        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            QuitGame();
        }
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            TutorialMode();
        }
    }

    public void LoadGame()
    {
        Debug.Log("Loading Game...");
        isTutorial = false;
        Tutorial.isTutorial3 = true;
        Time.timeScale = 1f;
        Score.scoreValue = 0;
        GameOver.isGameOver = false;
        SceneManager.LoadScene("CS498HW4");
    }

    public void TutorialMode()
    {
        Debug.Log("Loading Tutorial Mode");
        isTutorial = true;
        Tutorial.isTutorial3 = false;
        Time.timeScale = 1f;
        Score.scoreValue = 0;
        GameOver.isGameOver = false;
        SceneManager.LoadScene("CS498HW4");
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
