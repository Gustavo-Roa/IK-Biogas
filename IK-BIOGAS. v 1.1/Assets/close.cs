using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close : MonoBehaviour {
    public int escena;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void cerrar() {

        Application.LoadLevel(escena);
    }
}
