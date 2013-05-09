using UnityEngine;
using System.Collections;
using System;

public class Projectile : MonoBehaviour {

    public float speed = 1;
    public float lifeMs = 1000;


    private DateTime startTime;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, lifeMs / 1000); //schedule the object for deletion
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}

    void OnCollisionEnter(Collision collisionInfo)
    {
        Destroy(this.gameObject);
    }
}