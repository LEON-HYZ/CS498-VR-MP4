using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject plane;
    public Collider pcoll;
    public GameObject GameOverMenuUI;
    public static bool isGameOver = false;
    public static bool isCrashed = false;

    // Use this for initialization
    void Start()
    {
        //pcoll.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver && OVRInput.GetDown(OVRInput.RawButton.A))
        {
            RestartGame();
        }
        if (isGameOver && OVRInput.GetDown(OVRInput.RawButton.X))
        {
            LoadMenu();
        }
        if (isGameOver && OVRInput.GetDown(OVRInput.RawButton.B))
        {
            QuitGame();
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        GameOverMenuUI.SetActive(true);
        isGameOver = true;
        Time.timeScale = 0f;
        // pcoll.isTrigger = false;
        isCrashed = true;
    }

    public void RestartGame()
    {
        Debug.Log("Restarting Game...");
        isGameOver = false;
        Score.scoreValue = 0;
        Time.timeScale = 1f;
        //pcoll.isTrigger = true;
        SceneManager.LoadScene("CS498HW4");
    }
    public void LoadMenu()
    {
        Debug.Log("Loading Menu...");
        Time.timeScale = 1f;
        // pcoll.isTrigger = true;
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
