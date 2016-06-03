﻿using UnityEngine;

public class Particle : MonoBehaviour
{
    static Random random = new Random();

    public Vector2 acceleration = new Vector2(0.001f, 0.001f);
    public Vector2 velocity = new Vector2(Random.value, Random.value);
    public int lifeTime = 7;
    Vector2 position;

    // Use this for initialization
    void Start()
    {
        ParticleSpawner ps = (ParticleSpawner)FindObjectOfType(typeof(ParticleSpawner));
        position = ps.transform.position;
        velocity = new Vector2(Random.Range(-1f,1f), Random.Range(-1f,1f));
    }

    // Update is called once per frame
    void Update()
    {
        velocity += acceleration;

        position += velocity;
        lifeTime--;

        transform.position = position;

        if (isDead())
        {
            Destroy(gameObject);
        }

    }

    public Particle(Vector2 position)
    {
        this.position = position;
    }

    public bool isDead()
    {
        return lifeTime < 0;
    }
}
