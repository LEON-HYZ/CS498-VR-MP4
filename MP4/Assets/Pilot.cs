using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilot : MonoBehaviour {
    public static float speed = 10.0f;
    //public GameObject propeller;
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
        if(Input.GetKey(KeyCode.K)) speed += Time.deltaTime * 15.0f;
        if (speed > 80.0f) speed = 80.0f;
        
        
        speed -= OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) * Time.deltaTime * 15.0f;
        if (Input.GetKey(KeyCode.L)) speed -= Time.deltaTime * 15.0f;
        if (speed < 5.0f && !Menu.isTutorial) speed = 5.0f;

        transform.Rotate(0.1f*Input.GetAxis("Vertical"), 0.1f * Input.GetAxis("Horizontal"), -0.1f*Input.GetAxis("Horizontal"));

        transform.Rotate(0.10f * OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).y,
                         0.10f * OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x,
                         -0.10f * OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).x);
		
	}
}
