#pragma strict


function OnTriggerEnter (obj : Collider) {
	var thedoor = gameObject.FindWithTag("Exit");
	thedoor.GetComponent.<Animation>().Play("open");
}

function OnTriggerExit (obj : Collider) {
	var thedoor = gameObject.FindWithTag("Exit");
	thedoor.GetComponent.<Animation>().Play("close");
}