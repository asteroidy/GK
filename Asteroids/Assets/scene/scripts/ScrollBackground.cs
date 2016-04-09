using UnityEngine;
using System.Collections;

public class ScrollBackground : MonoBehaviour
{

    public static bool isPushed = false;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckIsButtonPushed();
        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material material = mr.material;
        Vector2 offset = material.mainTextureOffset;
        offset.y += 0.006f;
        material.mainTextureOffset = offset;
    }

    public void CheckIsButtonPushed()
    {
        if (Input.GetButtonDown("ShowMenu"))
        {
            isPushed = true;
            Application.LoadLevel(2);
        }
    }

}
