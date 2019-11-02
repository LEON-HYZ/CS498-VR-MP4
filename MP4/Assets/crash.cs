using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crash : MonoBehaviour {
    public AudioClip MusicClip;
    public AudioSource MusicSource;

    // Use this for initialization
    void Start () {
        MusicSource.clip = MusicClip;
    }
	
	// Update is called once per frame
	void Update () {
        if (GameOver.isCrashed)
        {
            MusicSource.time = 6f;
            MusicSource.Play();
            GameOver.isCrashed = false;
        }
	}
}
