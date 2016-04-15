#pragma strict

function OnTriggerEnter(other : Collider){
	if(other.tag == "Player"){
		//doSomething or
		Application.LoadLevel(2);
	}
}