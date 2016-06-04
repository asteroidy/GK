using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class StateSingleton : MonoBehaviour
{
    bool paused;
    public static StateSingleton Instance;
    public Stopwatch gameTime = new Stopwatch();
    public Vector3 shipPosition;
    public bool shouldRotateCamera = false;
    public bool isPaused()
    {
        return paused;
    }

    public void setPaused(bool paused)
    {
        this.paused = paused;
    }

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
