using RAIN.Action;
using RAIN.Core;
using UnityEngine;

[RAINAction]
public class DetermineTargetLocation : RAINAction
{
	EnemyShooting enemyShoot;
	GameObject playerTarget;

	public override void Start (AI ai)
	{
		enemyShoot = ai.Body.GetComponent<EnemyShooting>();
	}


	public override ActionResult Execute(AI ai)
	{

		return ActionResult.SUCCESS;
	}
}