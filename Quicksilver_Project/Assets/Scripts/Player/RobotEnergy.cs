using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RobotEnergy : MonoBehaviour 
{
	public int startingEnergy;
	public int currentEnergy;
	public float flashSpeed = 5f;
	public Image damageImage;
	public GameObject energyBar;
	public Color damageColor = new Color(1f, 0f, 0f, 0.1f);
	bool damaged;
	bool isDead;
	private GUIBarScript energyMeter;

	// Use this for initialization
	void Start () 
	{
		currentEnergy = startingEnergy;
		energyMeter = energyBar.GetComponent<GUIBarScript>();
		energyMeter.Value = (currentEnergy/100f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(damaged)
		{
			damageImage.color = damageColor;
		}
		else
		{
			damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		damaged = false;

		energyMeter.Value = (currentEnergy/100f);
	}

	public void TakeDamage (int amount)
	{
		damaged = true;
		
		currentEnergy -= amount;

		if(currentEnergy <= 0 && !isDead)
		{
			Death ();
		}
	}

	public void IncreaseEnergy (int amount)
	{
		currentEnergy += amount;
	}

	void Death ()
	{
		isDead = true;		
		GameObject.Find("GameManager").GetComponent<GameManager>().OpenSuccessScreen();
	}

}
