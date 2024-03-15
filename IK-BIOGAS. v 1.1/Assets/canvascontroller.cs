using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvascontroller : MonoBehaviour {
    public GameObject[] pantallas;
    public GameObject[] Pantallasreiniciar;
    public GameObject pantallaAbrir;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void abrirpantalla() {
        for (int i = 0; i < pantallas.Length; i++)
        {

            pantallas[i].SetActive(false);

        }
       

    }

    public void seleccion (int NumeroPantalla)
    {

        for (int i = 0; i < pantallas.Length; i++) {

            pantallas[i].SetActive(false);

        }
        pantallas[NumeroPantalla].SetActive(true);

    }



    public void reiniciar() {
        for (int i = 0; i < Pantallasreiniciar.Length; i++) {


            Pantallasreiniciar[i].GetComponent<cerdosengorde>().opcionesavanzadas = false;

        }

    }
}
