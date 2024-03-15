using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class temperaturaavanzada : MonoBehaviour {
    public InputField input1;
    public InputField input2;
    public InputField input3;
    public float TrhDias;
    public float DilucionMezclaPorcentaje;
    public float VolumenGasPorcentaje;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void siguiente() {
        TrhDias = float.Parse(input1.text);
        DilucionMezclaPorcentaje = float.Parse(input2.text);
        VolumenGasPorcentaje = float.Parse(input3.text);

    }
}
