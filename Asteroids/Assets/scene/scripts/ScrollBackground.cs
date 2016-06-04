using UnityEngine;
using System.Collections;

public class ScrollBackground : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material material = mr.material;
        Vector3 offset = material.mainTextureOffset;
        offset.y += 0.006f;
        material.mainTextureOffset = offset;
    }

}
