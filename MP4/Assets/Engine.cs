using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour {
    public AudioClip MusicClip;

    public AudioSource MusicSource;
    // Use this for initialization
    void Start () {
        MusicSource.clip = MusicClip;
        MusicSource.Play();
    }
	
	// Update is called once per frame
	void Update () {
        if (GameOver.isGameOver)
        {
            MusicSource.Pause();
        }
        if (PauseMenu.GameIsPaused)
        {
            MusicSource.Pause();
            PauseMenu.GameIsUnpaused = false;
        }
        else
        {
            if (!PauseMenu.GameIsUnpaused)
            {
                MusicSource.UnPause();
                PauseMenu.GameIsUnpaused = true;
            }
            
        }
        
    }
}
