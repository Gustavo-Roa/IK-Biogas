using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reemplazar : MonoBehaviour {

    public string nombre;
    public Sprite icono;
    public Sprite fondo;
    public GameObject opcionesavanzadas;
    public GameObject selecciones;
    public float biogasm3;
    public bool eficienciagenerador;
    public float reemplazarfloat;
    public float factor65ch4;
    public bool avanzadas;
    public InputField reemplazarinput;
    public InputField eficienciageneradorporcentaje;
    public float generador;
    public int numeroseleccionado;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    public void call() {

        if (eficienciagenerador == true)
        {
            electricidad();

        }
        else {

            continuar();

        }

       

    }
    public void changuetoadvance()
    {
        avanzadas = true;
    }
    public void cocina() {

        if (avanzadas == false)
        {

            reemplazarfloat = float.Parse(reemplazarinput.text);
            generador = float.Parse(eficienciageneradorporcentaje.text) ;

            biogasm3 = reemplazarfloat * factor65ch4 * generador;
            numeroseleccionado = selecciones.GetComponent<selecciones>().numero;
            selecciones.GetComponent<selecciones>().biogasm3[numeroseleccionado] = biogasm3;
            selecciones.GetComponent<selecciones>().imagenfondo[numeroseleccionado] = fondo;
            selecciones.GetComponent<selecciones>().imagenicon[numeroseleccionado] = icono;
            selecciones.GetComponent<selecciones>().nombres[numeroseleccionado] = nombre;

            selecciones.GetComponent<selecciones>().numero += 1;

        }
        else
        {

            reemplazarfloat = float.Parse(reemplazarinput.text);
            factor65ch4 = opcionesavanzadas.GetComponent<reemplazaravanzadas>().factor65ch4;
           generador = float.Parse(eficienciageneradorporcentaje.text) ;
            numeroseleccionado = selecciones.GetComponent<selecciones>().numero;
            biogasm3 = reemplazarfloat * factor65ch4 *generador;
            selecciones.GetComponent<selecciones>().imagenfondo[numeroseleccionado] = fondo;
            selecciones.GetComponent<selecciones>().imagenicon[numeroseleccionado] = icono;
            selecciones.GetComponent<selecciones>().nombres[numeroseleccionado] = nombre;
            selecciones.GetComponent<selecciones>().numero += 1;


        }




    }

    public void electricidad() {

        if (avanzadas == false) {

            reemplazarfloat = float.Parse(reemplazarinput.text);
            generador = float.Parse(eficienciageneradorporcentaje.text);
            

            biogasm3 = (factor65ch4 * reemplazarfloat )/ generador*100;
            numeroseleccionado = selecciones.GetComponent<selecciones>().numero;
            selecciones.GetComponent<selecciones>().biogasm3[numeroseleccionado] = biogasm3;
            selecciones.GetComponent<selecciones>().imagenfondo[numeroseleccionado] = fondo;
            selecciones.GetComponent<selecciones>().imagenicon[numeroseleccionado] = icono;
            selecciones.GetComponent<selecciones>().nombres[numeroseleccionado] = nombre;

            selecciones.GetComponent<selecciones>().numero += 1;

        } else {

            reemplazarfloat = float.Parse(reemplazarinput.text);
            factor65ch4 = opcionesavanzadas.GetComponent<reemplazaravanzadas>().factor65ch4;
            generador = float.Parse(eficienciageneradorporcentaje.text) / 100;
            numeroseleccionado = selecciones.GetComponent<selecciones>().numero;
            biogasm3 = reemplazarfloat * factor65ch4 / generador*100;
            selecciones.GetComponent<selecciones>().imagenfondo[numeroseleccionado] = fondo;
            selecciones.GetComponent<selecciones>().imagenicon[numeroseleccionado] = icono;
            selecciones.GetComponent<selecciones>().nombres[numeroseleccionado] = nombre;
            selecciones.GetComponent<selecciones>().numero += 1;


        }

    }
    public void continuar() {

        if (avanzadas == false)
        {        
                reemplazarfloat = float.Parse(reemplazarinput.text);
            //generador = float.Parse(eficienciageneradorporcentaje.text)/100;
            biogasm3 = reemplazarfloat * factor65ch4  ;
            numeroseleccionado = selecciones.GetComponent<selecciones>().numero;
            selecciones.GetComponent<selecciones>().biogasm3[numeroseleccionado] = biogasm3;
            selecciones.GetComponent<selecciones>().imagenfondo[numeroseleccionado] = fondo;
            selecciones.GetComponent<selecciones>().imagenicon[numeroseleccionado] = icono;
            selecciones.GetComponent<selecciones>().nombres[numeroseleccionado] = nombre;
            selecciones.GetComponent<selecciones>().numero += 1;


        }

        //division avanzadas
        else {

            reemplazarfloat = float.Parse(reemplazarinput.text);
          //  generador = float.Parse(eficienciageneradorporcentaje.text) / 100;
            factor65ch4 = opcionesavanzadas.GetComponent<reemplazaravanzadas>().factor65ch4;
            biogasm3 = reemplazarfloat * factor65ch4;
            numeroseleccionado = selecciones.GetComponent<selecciones>().numero;
            selecciones.GetComponent<selecciones>().biogasm3[numeroseleccionado] = biogasm3;
            selecciones.GetComponent<selecciones>().imagenfondo[numeroseleccionado] = fondo;
            selecciones.GetComponent<selecciones>().imagenicon[numeroseleccionado] = icono;
            selecciones.GetComponent<selecciones>().nombres[numeroseleccionado] = nombre;
            selecciones.GetComponent<selecciones>().numero += 1;


        }


    }
}
