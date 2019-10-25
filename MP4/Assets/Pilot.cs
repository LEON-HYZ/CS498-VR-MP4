using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilot : MonoBehaviour {
    public float speed = 30.0f;
	// Use this for initialization
	void Start () {
        Debug.Log("plane pilot script added to:" + gameObject.name);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * Time.deltaTime * speed;
        //speed -= transform.forward.y * Time.deltaTime * 15.0f;
        //if (speed < 5.0f) speed = 5.0f;
        
        speed += OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger) * Time.deltaTime * 15.0f;
        if (speed > 80.0f) speed = 80.0f;
        
        
        speed -= OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger) * Time.deltaTime * 15.0f;
        if (speed < 5.0f) speed = 5.0f;
        

        transform.Rotate(0.10f * OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).y, 
                         0.10f * OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).x, 
                         0.10f * -OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x);
		
	}
}
