#pragma strict


function Update () {
	var mr : MeshRenderer;
	mr = GetComponent.<MeshRenderer>();

	var material : Material = mr.material;
	var offset : Vector2 = material.mainTextureOffset;
	offset.y+=0.006;
	material.mainTextureOffset = offset;
}