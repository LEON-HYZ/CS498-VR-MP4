using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject plane;
    public Collider pcoll;
    public GameObject GameOverMenuUI;
    public int GameIsOver = 0;
    // Use this for initialization
    void Start()
    {
        pcoll.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        GameOverMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsOver = 1;
    }

    public void RestartGame()
    {
        Debug.Log("Restarting Game...");
        Time.timeScale =1f;
        SceneManager.LoadScene("CS498HW4");
    }
    public void LoadMenu()
    {
        Debug.Log("Loading Menu...");
        Time.timeScale = 1f;
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
