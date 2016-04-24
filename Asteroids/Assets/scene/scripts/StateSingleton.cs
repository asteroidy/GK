using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class StateSingleton : MonoBehaviour
{
    public static StateSingleton Instance;
    public Stopwatch gameTime = new Stopwatch();
    public Vector3 shipPosition;
    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
