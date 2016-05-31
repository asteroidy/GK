using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour
{

    volatile ArrayList asteroids = Spawner.asteroids;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        asteroids = Spawner.asteroids;
        foreach (GameObject asteroid in asteroids)
        {
            float leftBound = transform.position.x - (GetComponent<MeshFilter>().mesh.bounds.size.x / 2);
            float rightBound = transform.position.x + (GetComponent<MeshFilter>().mesh.bounds.size.x / 2);
            float upperBound = transform.position.y + (GetComponent<MeshFilter>().mesh.bounds.size.y / 2);
            float bottomBound = transform.position.y - (GetComponent<MeshFilter>().mesh.bounds.size.y / 2);

            float asteroidLeftBound = asteroid.transform.position.x - (asteroid.GetComponent<MeshFilter>().mesh.bounds.size.x / 2) + 0.3f;
            float asteroidRightBound = asteroid.transform.position.x + (asteroid.GetComponent<MeshFilter>().mesh.bounds.size.x / 2) - 0.3f;
            float asteroidUpperBound = asteroid.transform.position.y + (asteroid.GetComponent<MeshFilter>().mesh.bounds.size.y / 2) - 0.3f;
            float asteroidBottomBound = asteroid.transform.position.y - (asteroid.GetComponent<MeshFilter>().mesh.bounds.size.y / 2) + 0.3f;

            if ((upperBound >= asteroidBottomBound && upperBound < asteroidUpperBound) || (bottomBound <= asteroidUpperBound && bottomBound > asteroidBottomBound))
            {
                if ((leftBound <= asteroidRightBound && leftBound > asteroidLeftBound) || (rightBound > asteroidLeftBound && rightBound < asteroidRightBound))
                {
                    Destroy(gameObject);
                    Application.LoadLevel("GameResult");
                }
            }

        }
    }
}
