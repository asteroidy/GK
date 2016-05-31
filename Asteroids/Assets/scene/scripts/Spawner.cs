using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject[] obj;
    public float spawnMin = 1;
    public float spawnMax = 2;
    public static ArrayList asteroids = new ArrayList();

    // Use this for initialization
    void Start () {
        InvokeRepeating("Spawn", Random.Range(spawnMin, spawnMax), Random.Range(spawnMin, spawnMax));
    }
	
	void Spawn () {
        asteroids.Add((GameObject)Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity));
        //Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
    }
}
