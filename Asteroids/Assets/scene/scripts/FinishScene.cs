using UnityEngine;
using System.Collections;
using System;
using System.Diagnostics;

public class FinishScene : MonoBehaviour {

    private GUIStyle style;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    void OnGUI()
    {
        style = new GUIStyle();
        style.fontSize = 5;
        style.fontStyle = FontStyle.Normal;
        StateSingleton.Instance.gameTime.Stop();
        Stopwatch finalScore = StateSingleton.Instance.gameTime;
        TimeSpan ts = finalScore.Elapsed;
        GUI.Label(new Rect(780f, 465f, 300f, 200f), "Congratulation!\n Your score is " + (ts.TotalMilliseconds / 1000).ToString() + " seconds!");
    }
}
