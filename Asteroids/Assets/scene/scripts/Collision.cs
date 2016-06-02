using UnityEngine;
using System;

public class Collision : MonoBehaviour
{
    void Update()
    {
        foreach (GameObject asteroid in Spawner.asteroids)
        {
            if (asteroid != null)
            {
                if (checkColision(asteroid))
                {
                    //Destroy(gameObject);
                    Spawner.asteroids.Clear();
                    Application.LoadLevel("GameResult");
                    break;
                }
            }

        }
    }

    bool checkColision(GameObject asteroid)
    {
        Vector2 asteroidSize = asteroid.GetComponent<MeshFilter>().mesh.bounds.size;
        Vector2 asteroidPosition = asteroid.transform.position;
        Vector2 bodySize, bodyPosition, wingsSize, wingsPosition, beakSize, beakPosition;

        bodySize.x = GetComponent<MeshFilter>().mesh.bounds.size.x * 0.42f; // 6 kratek (z 14)
        bodySize.y = GetComponent<MeshFilter>().mesh.bounds.size.y * 0.887f; //krótszy o 2,5 kratki
        bodyPosition.x = transform.position.x;
        bodyPosition.y = transform.position.y - (GetComponent<MeshFilter>().mesh.bounds.size.y / 9); //środek niżej o 2,5 kratki

        wingsSize.x = GetComponent<MeshFilter>().mesh.bounds.size.x;    //cała wys 22, wysokość skrzydeł 9
        wingsSize.y = GetComponent<MeshFilter>().mesh.bounds.size.y * 0.41f;
        wingsPosition.x = transform.position.x;
        wingsPosition.y = transform.position.y - (GetComponent<MeshFilter>().mesh.bounds.size.y / 11); //środek niżej o 2 kratki (1/11 z 22)

        beakSize.x = GetComponent<MeshFilter>().mesh.bounds.size.x / 7; //szerokość całego statku 14, szerokość dzioba 2 (1/7)
        beakSize.y = GetComponent<MeshFilter>().mesh.bounds.size.y;
        beakPosition = transform.position;


        return ((intersect(asteroidSize, asteroidPosition, bodySize, bodyPosition))
            || (intersect(asteroidSize, asteroidPosition, wingsSize, wingsPosition))
            || (intersect(asteroidSize, asteroidPosition, beakSize, beakPosition)));
    }

    bool intersect(Vector2 colliderSize, Vector2 colliderPosition, Vector2 objectSize, Vector2 objectPosition)
    {
        Vector2 distance = new Vector2();
        distance.x = Math.Abs(colliderPosition.x - objectPosition.x);
        distance.y = Math.Abs(colliderPosition.y - objectPosition.y);
        float r = colliderSize.x / 2;

        if ((distance.x > (objectSize.x / 2 + r)) || (distance.y > (objectSize.y / 2 + r)))
            return false;

        if ((distance.x <= (objectSize.x / 2)) || (distance.y <= (objectSize.y / 2)))
            return true;

        double cornerDistance = Math.Sqrt(distance.x - objectSize.x / 2) + Math.Sqrt(distance.y - objectSize.y / 2);

        return (cornerDistance <= Math.Sqrt(r));
    }

}
