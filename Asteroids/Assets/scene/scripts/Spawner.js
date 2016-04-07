#pragma strict

var obj : GameObject[];
var spawnMin : float = 1f;
var spawnMax : float = 2f;

function Start () {
	Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
}

function Spawn () {
	Instantiate (obj [Random.Range (0, obj.GetLength(0))], transform.position, Quaternion.identity);
	Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
}