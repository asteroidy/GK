using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Diagnostics;

public class StartMenu : MonoBehaviour {


	// Use this for initialization
	void Start () {
        StateSingleton.Instance.gameTime.Reset();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void StartGame()
    {
        Application.LoadLevel(1);
        StateSingleton.Instance.gameTime.Start();
    }

    public void EndGame()
    {
        Application.Quit();
    }

}
