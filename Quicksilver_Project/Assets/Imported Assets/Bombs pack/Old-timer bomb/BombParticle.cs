using UnityEngine;
using System.Collections;

public class BombParticle : MonoBehaviour {

	void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.tag == "Glass")
		{ //screw good programming
			Debug.Log ("Bomb breaks glass!");
			collision.gameObject.GetComponent<GlassBreak>().Break();
			Destroy(gameObject);
		}
	}
}
