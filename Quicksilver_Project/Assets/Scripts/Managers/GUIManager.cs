﻿using UnityEngine;
using System.Collections;
using ProgressBar;

public class GUIManager : MonoBehaviour 
{

	public GameObject ShrinkMeterGUI;
	public GameObject dashButtonGUI;
	public GameObject attackButtonGUI;
	public GameObject shootButtonGUI;
	public GameObject jumpButtonGUI;

	public float shrinkProgressSpeed;
	public float dashProgressSpeed;
	public float attackProgressSpeed;
	public float shootProgressSpeed;
	public float jumpProgressSpeed;

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

		dashButton = dashButtonGUI.GetComponentInChildren<ProgressRadialBehaviour>();
		dashButton.ProgressSpeed = dashProgressSpeed;
		dashButton.IncrementValue(100f);

		attackButton = attackButtonGUI.GetComponentInChildren<ProgressRadialBehaviour>();
		attackButton.ProgressSpeed = attackProgressSpeed;
		attackButton.IncrementValue(100f);

		shootButton = shootButtonGUI.GetComponentInChildren<ProgressRadialBehaviour>();
		shootButton.ProgressSpeed = shootProgressSpeed;
		shootButton.IncrementValue(100f);

		jumpButton = jumpButtonGUI.GetComponentInChildren<ProgressRadialBehaviour>();
		jumpButton.ProgressSpeed = jumpProgressSpeed;
		jumpButton.IncrementValue(100f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (shootButton.Value == 0f && shootButton.isPaused)
		{
			shootButton.ProgressSpeed = shootProgressSpeed;
			shootButton.IncrementValue(100f);
		}

		if (attackButton.Value == 0f && attackButton.isPaused)
		{
			attackButton.ProgressSpeed = attackProgressSpeed;
			attackButton.IncrementValue(100f);
		}
	}

	public void StartAttackCooldown()
	{
		attackButton.ProgressSpeed = 3.0f;
		attackButton.Value = 0.0f;
	}

	public void StartShootCooldown()
	{
		shootButton.ProgressSpeed = 2.0f;
		shootButton.Value = 0.0f;
	}

	public void StartShrinkTimer()
	{
		shrinkMeter.DecrementValue(100f);
	}

	public void StartShrinkRecharge()
	{
		shrinkMeter.IncrementValue(100f);
	}

	public bool IsShrinkReady()
	{
		return (shrinkMeter.isDone && shrinkMeter.isPaused);
	}

	public bool IsShrinkOver()
	{
		return (shrinkMeter.isPaused && shrinkMeter.Value == 0.0f);
	}

	public bool IsAttackReady()
	{
		return (attackButton.isDone && attackButton.isPaused);
	}

	public bool IsShootReady()
	{
		return (shootButton.isDone && shootButton.isPaused);
	}
}
