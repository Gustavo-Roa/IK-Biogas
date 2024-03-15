using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class datostecnicos : MonoBehaviour {

    // Use this for initialization
    public Text[] testos;
    public GameObject resultados;
    public GameObject seleccionado;
    public GameObject temperatura;
    public float[] equivalencias;
    public float[] factorrh65;
    public string[] nombres;
    public float biogastotal;
    public string[] unidad;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void actualizar() {

        testos[0].text = resultados.GetComponent<resultado>().mfkgrealdefinitivo.ToString("0") + " KG/DIA";
       testos[1].text = seleccionado.GetComponent<seleccionado>().kgStDefinitivo.ToString("0") + " KG/DIA";
        testos[2].text = seleccionado.GetComponent<seleccionado>().KgSvDefinitvo.ToString("0") + " KG/DIA";
        testos[3].text = resultados.GetComponent<resultado>().cargadiaria.ToString("0") + " LITROS/DIA";
        testos[4].text = resultados.GetComponent<resultado>().volumenliquido.ToString("0") + " M3";
        testos[5].text = resultados.GetComponent<resultado>().volumengaseoso.ToString("0") + " M3";
        testos[6].text = temperatura.GetComponent<temperatura>().TrhDias.ToString() + " DIAS";
        testos[7].text = resultados.GetComponent<resultado>().redondeandocova.ToString() + " KG SV/DIA";
        


    }

    public void equivalenciasen() {
        biogastotal = (float) resultados.GetComponent<resultado>().biogastotalm3definitvo;
        for (int i = 0; i < equivalencias.Length; i++) {


            equivalencias[i] = factorrh65[i] * biogastotal;



        }


        for (int i = 0; i < equivalencias.Length; i++)
        {


            testos[i].text = equivalencias[i].ToString("0") + " " + unidad[i];



        }
    }
}
