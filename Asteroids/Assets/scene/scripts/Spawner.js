#pragma strict

var obj : GameObject[];
var spawnMin : float = 1;
var spawnMax : float = 2;

function Start () {
	InvokeRepeating ("Spawn", Random.Range (spawnMin, spawnMax), Random.Range (spawnMin, spawnMax));
}

function Spawn () {
	Instantiate (obj [Random.Range (0, obj.GetLength(0))], transform.position, Quaternion.identity);
}