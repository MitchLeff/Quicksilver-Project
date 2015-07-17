using UnityEngine;
using System.Collections;
using RAIN.Core;

public class EnemyHealth : MonoBehaviour 
{

	public int Health = 10;

	private Animator anim;
	private AIRig ai;
	private int startingHealth;
	private CapsuleCollider col;
	public GameObject DamageSmokePS;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
		ai = GetComponentInChildren<AIRig>();
		col = GetComponent<CapsuleCollider>();
		startingHealth = Health;
	}
	
	// Update is called once per frame
	void Update () 
	{
		ParticleSystem ps = DamageSmokePS.GetComponent<ParticleSystem>();

		if (Health <= startingHealth/2 && !ps.isPlaying)
		{
			ps.Play();
		}

		if (Health <= 0)
		{
			Die ();
		}

		if (anim.GetCurrentAnimatorStateInfo(0).IsName("TurnOffAnimator"))
		{
			anim.enabled = false;
			ps.Stop();
		}
	}

	public void TakeDamage (int amount)
	{
		Debug.Log ("Take Damage");
		Health = Health - amount;
		anim.SetFloat("Speed", 0f);
		anim.SetTrigger("HitTrigger");
	}

	public void Die ()
	{
		anim.SetBool("Death", true);
		ai.enabled = false;
		col.enabled = false;
		DamageSmokePS.transform.position = this.transform.position;
	}
}
