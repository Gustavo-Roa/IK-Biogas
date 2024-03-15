using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrir : MonoBehaviour {
    public GameObject pantallaAbrir;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    public void abrircanvas() {

        GameObject.FindGameObjectWithTag("Player").GetComponent<canvascontroller>().abrirpantalla();

        pantallaAbrir.SetActive(true);

    }
}
