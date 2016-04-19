#pragma strict

var speed : float;
var spin : float = 100;

var minSpeed : float = 9.0;
var maxSpeed : float = 14.0;

function Start () {
	speed = Random.Range (minSpeed, maxSpeed);
}

function Update () {
    transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
	transform.Rotate(Vector3.forward, spin * Time.deltaTime, Space.Self);
	transform.Rotate(Vector3.right, spin * Time.deltaTime, Space.Self);
}