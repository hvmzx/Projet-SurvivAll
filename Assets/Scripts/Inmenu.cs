﻿using UnityEngine;
using System.Collections;

public class Inmenu : MonoBehaviour {

	// Use this for initialization
	void Start () {	
		Screen.lockCursor = false;
		UnityEngine.Cursor.visible = true;
		GameObject.Find ("Manager").SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
