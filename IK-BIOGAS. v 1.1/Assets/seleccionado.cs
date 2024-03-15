using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seleccionado : MonoBehaviour {
	public GameObject[] objetos;
	public Sprite[] iconosprite;
	public Sprite[] fondosprite;
	public Button[] iconos;
	public Button[] fondos;
    public Text[] titulos;
	public string[] nombres;
    public float[] biogastotalm3;
    public float[] KgSv;
    public float[] KgSt;
    public float[] MfKgReal;
    public float biogastotalm3Definitivo;
    public float KgSvDefinitvo;
    public float kgStDefinitivo;
    public float MfKgRealDefinitivo;
	public int numero;
    public float cantidaddefinitiva;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    public void changevalue() {

		total ();



		
        for (int i = 0; i < numero ; i++) {
            

              /*  biogastotalm3[i] = GameObject.FindGameObjectsWithTag("produccion")[i].GetComponent<cerdosengorde>().biosgasTotalM3;
                KgSv[i] = GameObject.FindGameObjectsWithTag("produccion")[i].GetComponent<cerdosengorde>().KgSV;
                KgSt[i] = GameObject.FindGameObjectsWithTag("produccion")[i].GetComponent<cerdosengorde>().KgSt;
                MfKgReal[i] = GameObject.FindGameObjectsWithTag("produccion")[i].GetComponent<cerdosengorde>().MfKgReal; */
				iconos [i].image.sprite = iconosprite[i];  
				fondos [i].image.sprite = fondosprite[i];
                titulos[i].text = nombres[i];
				
          
            



        }





    }
    public void total() {

        biogastotalm3Definitivo = 0.0f;
        KgSvDefinitvo = 0.0f;
        kgStDefinitivo = 0.0f;
        MfKgRealDefinitivo = 0.0f;
        for (int i = 0; i <numero; i++)
        {
           

                biogastotalm3Definitivo = biogastotalm3Definitivo + biogastotalm3[i];
                KgSvDefinitvo += KgSv[i];
                kgStDefinitivo += KgSt[i];
                MfKgRealDefinitivo += MfKgReal[i];

            




        }



    }

}
