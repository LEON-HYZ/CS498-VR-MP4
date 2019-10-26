using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public GameObject bullet;
    public float bspeed = 100f;
	// Use this for initialization
	void Start () {
        bullet.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            
            GameObject instBullet = Instantiate(bullet, bullet.transform.position, bullet.transform.rotation) as GameObject;
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.AddForce(new Vector3 (bullet.transform.rotation.x, bullet.transform.rotation.y, bullet.transform.rotation.z) * bspeed);//-bullet.transform.forward
            
        }
    }
}
