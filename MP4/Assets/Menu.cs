using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

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
    }

    public void LoadGame()
    {
        Debug.Log("Loading Game...");
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
