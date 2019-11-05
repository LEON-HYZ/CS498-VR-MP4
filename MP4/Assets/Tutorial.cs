using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {

    public GameObject TutorialMenu;
    public GameObject Tutorial1;
    public GameObject Tutorial2;
    public GameObject Tutorial3;
    public GameObject Tutorial4;
    private float startTime = 0.0f;
    private bool isTutorial1 = false;
    private bool isTutorial2 = false;
    public static bool isTutorial3 = false;
    // Use this for initialization
    void Start () {
        if (Menu.isTutorial)
        {
            TutorialMenu.SetActive(true);
            Tutorial1.SetActive(true);
            Tutorial2.SetActive(false);
            Tutorial3.SetActive(false);
            Tutorial4.SetActive(false);
            Pilot.speed = 0.0f;
            isTutorial1 = true;
            isTutorial2 = false;
            isTutorial3 = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Menu.isTutorial)
        {
            startTime += Time.deltaTime;
            if(startTime > 3.0f && isTutorial1)
            {
                Pilot.speed = 5.0f;
                Tutorial1.SetActive(false);
                Tutorial2.SetActive(true);
                isTutorial1 = false;
                isTutorial2 = true;
            }
            if (isTutorial2 &&( OVRInput.Get(OVRInput.RawButton.A) || Input.GetKeyDown(KeyCode.Z)))
            {
                Tutorial2.SetActive(false);
                Tutorial3.SetActive(true);
                isTutorial2 = false;
                isTutorial3 = true;
                Menu.isTutorial = false;
                Debug.Log("Tutorial3");
            }
            
        }else if(isTutorial3 && (OVRInput.Get(OVRInput.RawButton.A) || Input.GetKeyDown(KeyCode.Z)))
        {
            Tutorial3.SetActive(false);
            Tutorial4.SetActive(true);
            isTutorial3 = false;
                
            Debug.Log("Tutorial4");
        }
		
	}
}
