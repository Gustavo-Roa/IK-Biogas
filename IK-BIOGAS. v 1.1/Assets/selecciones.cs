using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selecciones : MonoBehaviour {
    public float[] biogasm3;
    public string[] nombres;
    public Sprite[] imagenfondo;
    public Sprite[] imagenicon;
    public Button[] icons;
    public Button[] fondos;
    public Text[] textos;
    public float totalbiogasm3;
    public int numero;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void actualizar() {

        totalbiogasm3 = 0;
        for (int i = 0; i < numero; i++) {


            totalbiogasm3 += biogasm3[i];
            fondos[i].image.sprite = imagenfondo[i];
            icons[i].image.sprite = imagenicon[i];
            textos[i].text = nombres[i];



        }

        PlayerPrefs.SetFloat("totalbiogas", totalbiogasm3);

    }
}
