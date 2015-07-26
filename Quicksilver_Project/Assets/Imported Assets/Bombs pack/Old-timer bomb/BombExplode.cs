using UnityEngine;
using System.Collections;

public class BombExplode : MonoBehaviour 
{
	public Transform explodeObject;
	public float magnitudeCol, radius, power, upwards;
	
	void OnCollisionEnter(Collision collision)
	{
		if (collision.relativeVelocity.magnitude > magnitudeCol)
		{
			Destroy(gameObject);
			Instantiate(explodeObject, transform.position, transform.rotation);
		}
	}
}
