using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour {
    public AudioClip MusicClip;

    public AudioSource MusicSource;

	// Use this for initialization
	void Start () {
        MusicSource.clip = MusicClip;	
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger) || OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
        {
            MusicSource.Play();
        }
    }
}
