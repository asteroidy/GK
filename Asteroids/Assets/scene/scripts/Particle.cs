using UnityEngine;

public class Particle : MonoBehaviour
{
    static Random random = new Random();

    Vector2 acceleration = new Vector2(0.001f, 0.001f);
    Vector2 velocity = new Vector2(Random.value, Random.value);
    int lifeTime = 24;
    Vector2 position;

    // Use this for initialization
    void Start()
    {
        lifeTime = 60;
        ParticleSpawner ps = (ParticleSpawner)FindObjectOfType(typeof(ParticleSpawner));
        position = ps.transform.position;
        velocity = new Vector2(Random.Range(-1f,1f)/8, Random.Range(-1f,1f)/8);
    }

    // Update is called once per frame
    void Update()
    {
        velocity += acceleration;
        float newX = transform.localScale.x - 0.02f;
        //GetComponent<Renderer>().material.color = Color.red;
        if (newX > 0)
        {
            transform.localScale = new Vector3(newX, newX, newX);
        }
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
