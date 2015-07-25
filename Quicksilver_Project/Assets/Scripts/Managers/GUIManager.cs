using UnityEngine;
using System.Collections;
using ProgressBar;

public class GUIManager : MonoBehaviour 
{

	public GameObject ShrinkMeterGUI;
	public GameObject dashButtonGUI;
	public GameObject attackButtonGUI;
	public GameObject shootButtonGUI;
	public GameObject jumpButtonGUI;

	private ProgressBarBehaviour shrinkMeter;
	private ProgressRadialBehaviour dashButton;
	private ProgressRadialBehaviour attackButton;
	private ProgressRadialBehaviour shootButton;
	private ProgressRadialBehaviour jumpButton;


	// Use this for initialization
	void Start () 
	{
		shrinkMeter = ShrinkMeterGUI.GetComponent<ProgressBarBehaviour>();
		shrinkMeter.IncrementValue(100f);

		dashButton = dashButtonGUI.GetComponent<ProgressRadialBehaviour>();
		dashButton.IncrementValue(100f);

		attackButton = attackButtonGUI.GetComponent<ProgressRadialBehaviour>();
		attackButton.IncrementValue(100f);

		shootButton = shootButtonGUI.GetComponent<ProgressRadialBehaviour>();
		shootButton.IncrementValue(100f);

		jumpButton = jumpButtonGUI.GetComponent<ProgressRadialBehaviour>();
		jumpButton.IncrementValue(100f);


	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
