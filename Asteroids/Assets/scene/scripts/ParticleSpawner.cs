using UnityEngine;
using System.Collections;

public class ParticleSpawner : MonoBehaviour
{
    public static bool boom = false;
    public GameObject obj;
    ArrayList particles = new ArrayList();
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (boom)
        {
            for(int i = 0; i < 100; i++)
            {
                particles.Add(Instantiate(obj, transform.position, Quaternion.identity));

            }
        }
    }
}
