using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cerdosengordeavanzadas : MonoBehaviour {
    public int cantidad;
    public int PesoVivoPromedio;
    public int HorasEstabulacion;
    public bool EstabulacionAplica;
    private int TotalPesoVivo;
    public float ProduccionEstiercolPorcentaje;
    public float MfKgDia;
    public float MfKgReal;
    public float porcentajeSt;
    public float porcentajeSv;
    public float biogasM3KgSv;
    public float KgSt;
    public float KgSV;
    public float biosgasTotalM3;
    public GameObject settings;
    public InputField input1;
    public InputField input2;
    public InputField input3;
    public InputField input4;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
   
    }

    public void calcular()
    {

        TotalPesoVivo = cantidad * PesoVivoPromedio;
        MfKgDia = TotalPesoVivo * ProduccionEstiercolPorcentaje;
        if (EstabulacionAplica == true)
        {
            MfKgReal = MfKgDia * HorasEstabulacion / 24;
        }
        else
        {
            MfKgReal = MfKgDia;
        }
        KgSt = MfKgReal * porcentajeSt;
        KgSV = KgSt * porcentajeSv;
        biosgasTotalM3 = KgSV * biogasM3KgSv;

    }



    public void changueValues() {
        ProduccionEstiercolPorcentaje = float.Parse(input1.text);
        porcentajeSt = float.Parse(input2.text);
        porcentajeSv = float.Parse(input3.text);
        biogasM3KgSv = float.Parse(input4.text);



    }
}

