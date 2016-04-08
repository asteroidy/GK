#pragma strict

function OnTriggerEnter(other : Collider){
	if(other.tag == "asteroid"){
		Destroy(other.gameObject);
	}
}