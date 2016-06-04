using UnityEngine;
using System.Collections;

public class Affine : MonoBehaviour
{
    public Transform ship;

    void Start()
    {

    }

    void Update()
    {
        if (StateSingleton.Instance.shouldRotateCamera)
        {
            Vector3 relativePos = (ship.position + new Vector3(0f, 1.5f, 0f)) - transform.position;
            Quaternion rotation = Quaternion.LookRotation(relativePos);
            Quaternion current = transform.localRotation;
            transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
            transform.Translate(0, 0, 5 * Time.deltaTime);
        }
    }
}