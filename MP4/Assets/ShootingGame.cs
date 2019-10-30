using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingGame : MonoBehaviour
{
    public GameObject sphere;
    public Collider coll;
    private float startTime = 0f;
    public int sphereIsActive = 1;
    public int isCollided = 0;
    // Use this for initialization
    void Start()
    {
        coll.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sphereIsActive == 0)
        {
            if(isCollided == 1)
            {
                Score.scoreValue += 5;
                isCollided = 0;

            }
            
            startTime += Time.deltaTime;
            if (startTime > 5.0f)
            {
                sphere.SetActive(true);
                startTime = 0f;
                sphereIsActive = 1;
            }
        }

    }
    void OnTriggerEnter(Collider other)
    {
        sphere.SetActive(false);
        sphereIsActive = 0;
        isCollided = 1;
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
