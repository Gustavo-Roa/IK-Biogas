using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultado : MonoBehaviour {
    public bool UnidadAplica;
    public GameObject seleccionado;
    public GameObject temperatura;
    public Text[] textoresultados;
	public double biogastotalm3definitvo;
	public double kgsvdefinitivo;
	public double kgstdefinitvo;
	public double mfkgrealdefinitivo;
	public double cargadiaria;
	public double volumenliquido;
    public double volumenliquidolitros;
	public double volumengaseoso;
	public double volumentotal;
	public double cova;
	public double eqreduccionemisiones;
	public double ch465;
	public double agua;
	public double aguaadicionar;
	public double producciondeefluente;
	public double horasdecocina;
    public double redondeandocova;
    public double CANTIDADFLOTANTE;
    public int CANTIDADENTERO;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void showresults()
    {
        CANTIDADFLOTANTE = seleccionado.GetComponent<seleccionado>().cantidaddefinitiva;
        CANTIDADENTERO = (int)CANTIDADFLOTANTE;

        biogastotalm3definitvo = seleccionado.GetComponent<seleccionado>().biogastotalm3Definitivo;
		kgsvdefinitivo = seleccionado.GetComponent<seleccionado>().KgSvDefinitvo;
		kgstdefinitvo= seleccionado.GetComponent<seleccionado>().kgStDefinitivo;
		mfkgrealdefinitivo = seleccionado.GetComponent<seleccionado>().MfKgRealDefinitivo;
        
		cargadiaria = kgstdefinitvo/ temperatura.GetComponent<temperatura>().dilucionmezclaporcentaje *100;
		volumenliquidolitros = cargadiaria * temperatura.GetComponent<temperatura>().TrhDias ;
        volumenliquido = volumenliquidolitros / 1000;
		volumengaseoso = volumenliquido * temperatura.GetComponent<temperatura> ().VolumenGasPorcentaje / 100;
		volumentotal = System.Math.Round( volumenliquido, 0) +  System.Math.Round( volumengaseoso, 0);
		cova =  kgsvdefinitivo / volumenliquido;
        redondeandocova = System.Math.Round(cova, 2);
        ch465 = biogastotalm3definitvo * 0.65f;
		eqreduccionemisiones = ch465 * 0.7f * 23;
		agua = mfkgrealdefinitivo - kgstdefinitvo;
		aguaadicionar = System.Math.Round(cargadiaria,0) - System.Math.Round(agua,0);
		producciondeefluente = cargadiaria * 92 / 100;
        producciondeefluente = System.Math.Round(producciondeefluente, 0);

        horasdecocina = biogastotalm3definitvo / 0.3f;
        horasdecocina = System.Math.Round(horasdecocina, 0);
        eqreduccionemisiones = System.Math.Round(eqreduccionemisiones, 0);
        volumentotal = System.Math.Round(volumentotal);
        biogastotalm3definitvo =  System.Math.Round(biogastotalm3definitvo);

        textoresultados [0].text = biogastotalm3definitvo.ToString() + " M3/DIA";

        textoresultados[1].text = volumentotal.ToString() + " M3";
        textoresultados[2].text = aguaadicionar.ToString() + " LTS/DIA" ;
        textoresultados[3].text = producciondeefluente.ToString() + " LTS/DIA";
        textoresultados[4].text = horasdecocina.ToString()  + " HS/DIA";
        textoresultados[5].text = eqreduccionemisiones.ToString() +  " KG CO2 EQ/DIA";
        if (UnidadAplica == true)
        {
            textoresultados[6].text = CANTIDADENTERO.ToString() + " " +  PlayerPrefs.GetString("unidad");

        }
        else {
            textoresultados[6].text = CANTIDADENTERO.ToString();
        }

        
        PlayerPrefs.SetFloat("volumenliquido", (float)volumenliquido);


    }
}
