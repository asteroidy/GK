using UnityEngine;
using System.Collections;
using System;
using System.Diagnostics;

public class FinishScene : MonoBehaviour {

    private GUIStyle style = new GUIStyle();

	// Use this for initialization
	void Start () {
        StateSingleton.Instance.shipPosition = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    void OnGUI()
    {
        style.normal.textColor = Color.magenta;
        style.fontSize = 32;
        
        StateSingleton.Instance.gameTime.Stop();
        Stopwatch finalScore = StateSingleton.Instance.gameTime;
        Double ts = Math.Round(finalScore.Elapsed.TotalSeconds,2);
        GUI.Box( new Rect(640f,450f,300f,200f), "          Congratulation!\n Your score is " + ts.ToString() + " seconds!",style); // should be centered. 
    }
}
