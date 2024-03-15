using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class temperatura : MonoBehaviour
{
    public bool avanzadas;
    public float[] valores;
    public float trh;
    public float TrhDias;
    public float dilucionmezclaporcentaje;
    public float VolumenGasPorcentaje;
    public GameObject settings;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void temperaturaavanzada() {

        avanzadas = true;
    }

    public void seleccion(int numero)
    {
        trh = valores[numero];

    }

    public void calcular() {

        if (avanzadas == false)
        {


        }
        else {
           TrhDias = settings.GetComponent<temperaturaavanzada>().TrhDias;
            dilucionmezclaporcentaje = settings.GetComponent<temperaturaavanzada>().DilucionMezclaPorcentaje;

            VolumenGasPorcentaje =  settings.GetComponent<temperaturaavanzada>().DilucionMezclaPorcentaje;


        }



    }
}
