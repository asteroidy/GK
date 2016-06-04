using UnityEngine;
using System.Collections;

public class ParticleSpawner : MonoBehaviour
{
    public static bool boom = false;
    public GameObject obj;
    ArrayList particles = new ArrayList();
    static int limit;
    // Use this for initialization
    void Start()
    {
        limit = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        if (boom && limit>0)
        {
            for(int i = 0; i < 50; i++)
            {
                particles.Add(Instantiate(obj, transform.position, Quaternion.identity));
                limit--;

            }
        }
    }
}
