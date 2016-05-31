using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

    volatile ArrayList asteroids = Spawner.asteroids;
    volatile ArrayList asteroidsToDelete = new ArrayList();

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        foreach(GameObject ast in asteroidsToDelete)
        {
            Spawner.asteroids.Remove(ast);
        }

        asteroids = Spawner.asteroids;
        foreach (GameObject asteroid in asteroids)
        {
            if(transform.position.y>=asteroid.transform.position.y)
            {
                Destroy(asteroid.gameObject);
                asteroidsToDelete.Add(asteroid);
                //Spawner.asteroids.Remove(asteroid);
            }
        }
    }
}
