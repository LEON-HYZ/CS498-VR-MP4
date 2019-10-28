using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilot : MonoBehaviour {
    public float speed = 0.0f;
    //public GameObject bullet;
	// Use this for initialization
	void Start () {
        //bullet.SetActive(false);
        Debug.Log("plane pilot script added to:" + gameObject.name);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * Time.deltaTime * speed;
        //speed -= transform.forward.y * Time.deltaTime * 15.0f;
        //if (speed < 5.0f) speed = 5.0f;
        
        speed += OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger) * Time.deltaTime * 15.0f;
        if (speed > 80.0f) speed = 80.0f;
        
        
        speed -= OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) * Time.deltaTime * 15.0f;
        if (speed < 5.0f) speed = 0.0f;
        

        transform.Rotate(0.10f * OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).y,
                         0.10f * OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x,
                         -0.10f * OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).x);
		
	}
}
