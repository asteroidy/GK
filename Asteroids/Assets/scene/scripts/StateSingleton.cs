using UnityEngine;
using System.Collections;

public class StateSingleton : MonoBehaviour
{
    public static StateSingleton Instance;
    public int currentTimeOfGame;
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
