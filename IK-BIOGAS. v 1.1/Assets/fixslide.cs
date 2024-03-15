using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixslide : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
        GameObject.FindGameObjectWithTag("Player").GetComponent<canvascontroller>().seleccion(1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
