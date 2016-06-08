using UnityEngine;
using System.Collections;

public class Affine : MonoBehaviour
{
    public Transform ship;
    private Quaternion rotation;
    private Quaternion current;
    void Start()
    {
      
    }

    void Update()
    {
        if (StateSingleton.Instance.shouldRotateCamera)
        {
            Vector3 relativePos = (new Vector3(1.0f, 0.0f, 0.0f)) - transform.position;
            rotation = Quaternion.LookRotation(relativePos);
            current = transform.localRotation;
            transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
            transform.Translate(0, 0, 8 * Time.deltaTime);
        }
    }
}