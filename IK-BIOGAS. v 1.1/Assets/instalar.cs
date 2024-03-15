using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instalar : MonoBehaviour {
    public InputField anchodebolsainput;
    public float anchodebolsa;
    public float largozanja;
    public float alturazanja;
    public float anchosuperiorzanja;
    public float anchoinferiorzanja;
    public float largocortar;
    public float amarrecortar;
    public float totalplasticocortar;
    public float circunferencia;
    public float diametro;
    public float radio;
    public float CSBell;
    public float CSTrench;
    public float Rbell;
    public float h;
    public float n;
    public float volumenliquido;
    public float ntoradian;
    public Text[] datos;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void calcular() {


        anchodebolsa = float.Parse(anchodebolsainput.text);




        circunferencia = anchodebolsa * 2;
        diametro = circunferencia / Mathf.PI;
        radio = diametro / 2;
        anchoinferiorzanja = radio * 1.23f;
        anchosuperiorzanja = radio * 1.63f;
        alturazanja = radio * 1.54f;

        ntoradian = Mathf.PI * (n /2) / 180.0f;

        Rbell = (anchosuperiorzanja / 2) / Mathf.Sin(ntoradian);


        h = Mathf.Sqrt(Mathf.Pow(Rbell,2)-Mathf.Pow(anchosuperiorzanja/2,2) );

        CSBell =Mathf.PI * Mathf.Pow(Rbell,2) * (n / 360) - (anchosuperiorzanja * h) / 2;

        CSTrench = (alturazanja * (anchosuperiorzanja + anchoinferiorzanja)) / 2;

       // volumenliquido = PlayerPrefs.GetFloat("volumenliquido");
        largozanja =  volumenliquido / (CSBell +CSTrench);

        
        largocortar = largozanja;
        amarrecortar = 1.5f;
        totalplasticocortar = largocortar + amarrecortar;


        n = 118;


        datos[0].text = largozanja.ToString("0.00");
        datos[1].text = alturazanja.ToString("0.00");
        datos[2].text = anchosuperiorzanja.ToString("0.00");
        datos[3].text = anchoinferiorzanja.ToString("0.00");
        datos[4].text = largocortar.ToString("0.00");
        datos[5].text = totalplasticocortar.ToString("0.00");





    }
}
