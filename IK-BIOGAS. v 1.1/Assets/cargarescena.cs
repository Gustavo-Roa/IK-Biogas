﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cargarescena : MonoBehaviour {
    public int level;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void cargar(int lvel) {
        Application.LoadLevel(lvel);


    }
}
