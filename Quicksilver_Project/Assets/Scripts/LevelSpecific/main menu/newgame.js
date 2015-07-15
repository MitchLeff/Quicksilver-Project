#pragma strict


function OnTriggerEnter (obj : Collider) {
	var thedoor = gameObject.FindWithTag("New Game");
	thedoor.GetComponent.<Animation>().Play("open");
}

function OnTriggerExit (obj : Collider) {
	var thedoor = gameObject.FindWithTag("New Game");
	thedoor.GetComponent.<Animation>().Play("close");
}