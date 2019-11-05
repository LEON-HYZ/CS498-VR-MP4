using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public GameObject bulletEmitter;
    public GameObject bulletEmitter2;
    public GameObject bullet;
    public float bulletSpeed = 5000.0f;
	// Use this for initialization
	void Start () {
        bullet.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger) || Input.GetKeyDown(KeyCode.P))
        {
            GameObject tempBulletHandler = Instantiate(bullet, bulletEmitter.transform.position, bulletEmitter.transform.rotation) as GameObject;
            //tempBulletHandler.transform.Rotate(Vector3.left * 90);

            Rigidbody TempRigidbody = tempBulletHandler.GetComponent<Rigidbody>();
            
            TempRigidbody.AddForce(transform.forward.normalized * bulletSpeed);// * Time.deltaTime
            Destroy(tempBulletHandler, 5.0f);            
        }

        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger) || Input.GetKeyDown(KeyCode.O))
        {
            GameObject tempBulletHandler2 = Instantiate(bullet, bulletEmitter2.transform.position, bulletEmitter2.transform.rotation) as GameObject;
            //tempBulletHandler.transform.Rotate(Vector3.left * 90);

            Rigidbody TempRigidbody2 = tempBulletHandler2.GetComponent<Rigidbody>();

            TempRigidbody2.AddForce(transform.forward.normalized * bulletSpeed);// * Time.deltaTime
            Destroy(tempBulletHandler2, 5.0f);
        }
    }
}
