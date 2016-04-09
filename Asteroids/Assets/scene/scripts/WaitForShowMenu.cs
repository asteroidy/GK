﻿using UnityEngine;
using System.Collections;

public class WaitForShowMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        CheckIsButtonPushed();
	}

    public void CheckIsButtonPushed()
    {
        if (Input.GetButton("ShowMenu"))
        {
            Application.LoadLevel(2);
        }
    }
}
