﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ONMOUSE : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnMouseDown() {


        GameObject.FindGameObjectWithTag("Finish").GetComponent<abrir>().abrircanvas();

    }
}
