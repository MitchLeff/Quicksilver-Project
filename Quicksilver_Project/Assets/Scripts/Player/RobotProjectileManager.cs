// Team Quicksilver
// Rahmaan Lodhia
// William Gu
// Larry He
// Mitch Leff

using UnityEngine;
using System.Collections;

public class RobotProjectileManager : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnParticleCollision (GameObject other)
	{
		if (other.tag == "Enemy")
		{
			Debug.Log ("Enemy Hit");
			other.GetComponent<EnemyHealth>().TakeDamage(5);
		}
	}
}
