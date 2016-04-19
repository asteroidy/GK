#pragma strict

var shift = 0;
	var dir : boolean = true;	//true-right, false-left

function Start () {
	
}

function Update () {

	if(shift < -200){
		dir = true;
	}
	else if (shift >= 200){
		dir = false;
	}

	if(dir){
		transform.Translate(Vector3.right * Time.deltaTime, Space.World);
		shift++;
	} else{
		transform.Translate(Vector3.left * Time.deltaTime, Space.World);
		shift--;
	}
}