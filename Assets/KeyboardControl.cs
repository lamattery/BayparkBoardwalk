﻿using UnityEngine;
using System.Collections;

public class KeyboardControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.P)) {
            Application.CaptureScreenshot("luceCorner.png", 4);
        }
	}
}
