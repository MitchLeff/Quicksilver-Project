﻿using UnityEngine;
using System.Collections;

public class BombParticle : MonoBehaviour {

	//time until object is destroyed
	public float time, radius, power;

	void Start() {
		ApplyForce ();
	}

	void Update() {
		time -= Time.deltaTime;
		if (time < 0f) {
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.tag == "Player") {
			Debug.Log ("Bomb hurts player!");
			//insert player damage code here
		}

		if (collision.gameObject.tag == "Enemy") {
			Debug.Log ("Bomb hurts enemy!");
			collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(5);
		}

		if (collision.gameObject.tag == "Glass")
		{ //screw good programming
			Debug.Log ("Bomb breaks glass!");
			collision.gameObject.GetComponent<GlassBreak>().Break();
		}
		//ensures damage is not inflicted twice
		if (time < 0f) {
			Destroy(gameObject);
		}
	}

	void ApplyForce() {
		Vector3 explosionPos = transform.position;
		
		Collider[] colliders = Physics.OverlapSphere (explosionPos, radius);
		
		foreach (Collider hit in colliders)
		{
			string type = hit.gameObject.tag;
			if (type == "Player" || type == "Enemy" || type == "Bomb" || type == "Glass") {
				if (hit.GetComponent<Rigidbody>())
				{
					hit.GetComponent<Rigidbody>().AddExplosionForce(power, explosionPos, radius);
				}
			}
		}
	}
}
