using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour 
{
	public Vector3 targetPosition;

	LineRenderer attackLine;
	Animator anim;

	// Use this for initialization
	void Start () 
	{
		attackLine = GetComponent<LineRenderer>();
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
		{
			Shoot ();
		}
		else
		{
			DisableEffects ();
		}
	}

	public void DisableEffects()
	{
		attackLine.enabled = false;
	}

	void Shoot ()
	{
		attackLine.enabled = true;
		attackLine.SetPosition (0, transform.position);
		attackLine.SetPosition (1, targetPosition);
	}
}
