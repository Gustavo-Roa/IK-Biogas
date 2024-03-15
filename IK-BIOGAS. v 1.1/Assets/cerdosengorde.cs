using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cerdosengorde : MonoBehaviour
{
    public string unidad;
    public GameObject selecciones;
	public GameObject seleccionado;
	public int numeroseleccionado;
    public Sprite icono;
    public Sprite fondo;
    public string tipodeproductor;
    public int cantidad;
    public int PesoVivoPromedio;
    public int HorasEstabulacion;
    public bool EstabulacionAplica;
    public float TotalPesoVivo;
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
    public bool opcionesavanzadas;
    public InputField cantidadinput;
    public InputField pesoinput;
    public bool lista;
    public bool cultivos;
    public float cantidadcabezas;
    public GameObject resultadosinversos;




    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void changuetoAdvance()
    {

        opcionesavanzadas = true;

    }

    public void calcular()
    {
        lista = true;
        if (cultivos == false)
        {
            if (opcionesavanzadas == false)
            {


                cantidad = int.Parse(cantidadinput.text);
                PesoVivoPromedio = int.Parse(pesoinput.text);

                TotalPesoVivo = cantidad * PesoVivoPromedio;
                MfKgDia = TotalPesoVivo * ProduccionEstiercolPorcentaje;
                if (EstabulacionAplica == true)
                {
                    MfKgReal = MfKgDia * HorasEstabulacion / 24 /100;
                }
                else
                {
                    MfKgReal = MfKgDia / 100;
                }
                KgSt = MfKgReal * porcentajeSt  ;
                KgSV = KgSt * porcentajeSv ;
                 biosgasTotalM3 = KgSV * biogasM3KgSv ;


				numeroseleccionado = seleccionado.GetComponent<seleccionado> ().numero ;
				seleccionado.GetComponent<seleccionado> ().nombres [numeroseleccionado] = tipodeproductor;
				seleccionado.GetComponent<seleccionado> ().biogastotalm3 [numeroseleccionado] = biosgasTotalM3;
				seleccionado.GetComponent<seleccionado> ().KgSv [numeroseleccionado] = KgSV;
				seleccionado.GetComponent<seleccionado> ().KgSt [numeroseleccionado] = KgSt;
				seleccionado.GetComponent<seleccionado> ().MfKgReal [numeroseleccionado] = MfKgReal;
				seleccionado.GetComponent<seleccionado> ().iconosprite [numeroseleccionado] = icono;
				seleccionado.GetComponent<seleccionado> ().fondosprite [numeroseleccionado] = fondo;
				seleccionado.GetComponent<seleccionado> ().numero += 1;
            }
            else
            {


                cantidad = int.Parse(cantidadinput.text);
                PesoVivoPromedio = int.Parse(pesoinput.text);

                ProduccionEstiercolPorcentaje = settings.GetComponent<cerdosengordeavanzadas>().ProduccionEstiercolPorcentaje;
                porcentajeSt = settings.GetComponent<cerdosengordeavanzadas>().porcentajeSt /100;
                porcentajeSv = settings.GetComponent<cerdosengordeavanzadas>().porcentajeSv/100;
                biogasM3KgSv = settings.GetComponent<cerdosengordeavanzadas>().biogasM3KgSv;
                TotalPesoVivo = cantidad * PesoVivoPromedio;
                MfKgDia = TotalPesoVivo * ProduccionEstiercolPorcentaje;
                if (EstabulacionAplica == true)
                {
                    MfKgReal = MfKgDia * HorasEstabulacion / 24 / 100;
                }
                else
                {
                    MfKgReal = MfKgDia / 100;
                }

                KgSt = MfKgReal * porcentajeSt ;
                KgSV = KgSt * porcentajeSv;
                biosgasTotalM3 = KgSV * biogasM3KgSv;

                numeroseleccionado = seleccionado.GetComponent<seleccionado> ().numero ;
				seleccionado.GetComponent<seleccionado> ().nombres [numeroseleccionado] = tipodeproductor;
				seleccionado.GetComponent<seleccionado> ().biogastotalm3 [numeroseleccionado] = biosgasTotalM3;
				seleccionado.GetComponent<seleccionado> ().KgSv [numeroseleccionado] = KgSV;
				seleccionado.GetComponent<seleccionado> ().KgSt [numeroseleccionado] = KgSt;
				seleccionado.GetComponent<seleccionado> ().MfKgReal [numeroseleccionado] = MfKgReal;
				seleccionado.GetComponent<seleccionado> ().iconosprite [numeroseleccionado] = icono;
				seleccionado.GetComponent<seleccionado> ().fondosprite [numeroseleccionado] = fondo;
				seleccionado.GetComponent<seleccionado> ().numero += 1;

            }

        }





        else





        {
            if (opcionesavanzadas == false)
            {
                cantidad = int.Parse(cantidadinput.text);
                KgSt = cantidad * porcentajeSt / 100;
                KgSV = KgSt * porcentajeSv / 100 ;
				
                biosgasTotalM3 = KgSV * biogasM3KgSv ;

				numeroseleccionado = seleccionado.GetComponent<seleccionado> ().numero ;
				seleccionado.GetComponent<seleccionado> ().nombres [numeroseleccionado] = tipodeproductor;
				seleccionado.GetComponent<seleccionado> ().biogastotalm3 [numeroseleccionado] = biosgasTotalM3;
				seleccionado.GetComponent<seleccionado> ().KgSv [numeroseleccionado] = KgSV;
				seleccionado.GetComponent<seleccionado> ().KgSt [numeroseleccionado] = KgSt;
				seleccionado.GetComponent<seleccionado> ().MfKgReal [numeroseleccionado] = cantidad;
				seleccionado.GetComponent<seleccionado> ().iconosprite [numeroseleccionado] = icono;
				seleccionado.GetComponent<seleccionado> ().fondosprite [numeroseleccionado] = fondo;

				seleccionado.GetComponent<seleccionado> ().numero += 1;
            }
            else
            {


                cantidad = int.Parse(cantidadinput.text);
             

               
                porcentajeSt = settings.GetComponent<cerdosengordeavanzadas>().porcentajeSt / 100;
                porcentajeSv = settings.GetComponent<cerdosengordeavanzadas>().porcentajeSv / 100;
                biogasM3KgSv = settings.GetComponent<cerdosengordeavanzadas>().biogasM3KgSv;
               
              
            

                KgSt = cantidad * porcentajeSt ;

                KgSV = KgSt * porcentajeSv ;
				

                biosgasTotalM3 = KgSV * biogasM3KgSv;

				numeroseleccionado = seleccionado.GetComponent<seleccionado> ().numero ;
				seleccionado.GetComponent<seleccionado> ().nombres [numeroseleccionado] = tipodeproductor;
				seleccionado.GetComponent<seleccionado> ().biogastotalm3 [numeroseleccionado] = biosgasTotalM3;
				seleccionado.GetComponent<seleccionado> ().KgSv [numeroseleccionado] = KgSV;
				seleccionado.GetComponent<seleccionado> ().KgSt [numeroseleccionado] = KgSt;
				seleccionado.GetComponent<seleccionado> ().MfKgReal [numeroseleccionado] = cantidad;
				seleccionado.GetComponent<seleccionado> ().iconosprite [numeroseleccionado] = icono;
				seleccionado.GetComponent<seleccionado> ().fondosprite [numeroseleccionado] = fondo;
				seleccionado.GetComponent<seleccionado> ().numero += 1;

            }









        }



    }

    public void calcularinverso()
    {
        lista = true;
        if (cultivos == false)
        {
            if (opcionesavanzadas == false)
            {
                biosgasTotalM3 = selecciones.GetComponent<selecciones>().totalbiogasm3;

               
                PesoVivoPromedio = int.Parse(cantidadinput.text);
                KgSV = biosgasTotalM3/biogasM3KgSv;
                KgSt = KgSV / porcentajeSv;
                MfKgReal = KgSt / porcentajeSt;


                if (EstabulacionAplica == true) { 

                  
                   HorasEstabulacion = int.Parse(pesoinput.text);
                MfKgDia = MfKgReal * 24 / HorasEstabulacion;
                //  MfKgReal = MfKgDia * HorasEstabulacion / 24 / 100;
            }
                else
                {
                    MfKgDia = MfKgReal;
                }
                TotalPesoVivo = MfKgDia / ProduccionEstiercolPorcentaje ;
                cantidadcabezas = TotalPesoVivo / PesoVivoPromedio * 100;
               

                //cantidad

               numeroseleccionado = seleccionado.GetComponent<seleccionado>().numero;
                seleccionado.GetComponent<seleccionado>().cantidaddefinitiva = cantidadcabezas;
                seleccionado.GetComponent<seleccionado>().nombres[numeroseleccionado] = tipodeproductor;
                seleccionado.GetComponent<seleccionado>().biogastotalm3[numeroseleccionado] = biosgasTotalM3;
                seleccionado.GetComponent<seleccionado>().KgSv[numeroseleccionado] = KgSV;
                seleccionado.GetComponent<seleccionado>().KgSt[numeroseleccionado] = KgSt;
                seleccionado.GetComponent<seleccionado>().MfKgReal[numeroseleccionado] = MfKgReal;
                seleccionado.GetComponent<seleccionado>().iconosprite[numeroseleccionado] = icono;
                seleccionado.GetComponent<seleccionado>().fondosprite[numeroseleccionado] = fondo;
                PlayerPrefs.SetString("unidad", unidad);
                seleccionado.GetComponent<seleccionado>().numero += 1;
            }
            else
            {
                biosgasTotalM3 = selecciones.GetComponent<selecciones>().totalbiogasm3;


                ProduccionEstiercolPorcentaje = settings.GetComponent<cerdosengordeavanzadas>().ProduccionEstiercolPorcentaje;
                porcentajeSt = settings.GetComponent<cerdosengordeavanzadas>().porcentajeSt / 100;
                porcentajeSv = settings.GetComponent<cerdosengordeavanzadas>().porcentajeSv / 100;
                biogasM3KgSv = settings.GetComponent<cerdosengordeavanzadas>().biogasM3KgSv;
                PesoVivoPromedio = int.Parse(cantidadinput.text);
                KgSV = biosgasTotalM3 / biogasM3KgSv;
                KgSt = KgSV / porcentajeSv;
                MfKgReal = KgSt / porcentajeSt;


                if (EstabulacionAplica == true)
                {


                    HorasEstabulacion = int.Parse(pesoinput.text);
                    MfKgDia = MfKgReal * 24 / HorasEstabulacion;
                    //  MfKgReal = MfKgDia * HorasEstabulacion / 24 / 100;
                }
                else
                {
                    MfKgDia = MfKgReal;
                }
                TotalPesoVivo = MfKgDia / ProduccionEstiercolPorcentaje ;
                cantidadcabezas = TotalPesoVivo / PesoVivoPromedio * 100;


                //cantidad

                numeroseleccionado = seleccionado.GetComponent<seleccionado>().numero;
                seleccionado.GetComponent<seleccionado>().cantidaddefinitiva = cantidadcabezas;
                seleccionado.GetComponent<seleccionado>().nombres[numeroseleccionado] = tipodeproductor;
                seleccionado.GetComponent<seleccionado>().biogastotalm3[numeroseleccionado] = biosgasTotalM3;
                seleccionado.GetComponent<seleccionado>().KgSv[numeroseleccionado] = KgSV;
                seleccionado.GetComponent<seleccionado>().KgSt[numeroseleccionado] = KgSt;
                seleccionado.GetComponent<seleccionado>().MfKgReal[numeroseleccionado] = MfKgReal;
                seleccionado.GetComponent<seleccionado>().iconosprite[numeroseleccionado] = icono;
                seleccionado.GetComponent<seleccionado>().fondosprite[numeroseleccionado] = fondo;
                PlayerPrefs.SetString("unidad", unidad);
                seleccionado.GetComponent<seleccionado>().numero += 1;



            }

        }





        else





        {
            if (opcionesavanzadas == false)
            {

                
                biosgasTotalM3 = selecciones.GetComponent<selecciones>().totalbiogasm3;
                KgSV = biosgasTotalM3 / biogasM3KgSv;
                KgSt = KgSV / porcentajeSv;
                cantidadcabezas = KgSt / porcentajeSt;

                

                numeroseleccionado = seleccionado.GetComponent<seleccionado>().numero;
                seleccionado.GetComponent<seleccionado>().cantidaddefinitiva = cantidadcabezas;
                seleccionado.GetComponent<seleccionado>().nombres[numeroseleccionado] = tipodeproductor;
                seleccionado.GetComponent<seleccionado>().biogastotalm3[numeroseleccionado] = biosgasTotalM3;
                seleccionado.GetComponent<seleccionado>().KgSv[numeroseleccionado] = KgSV;
                seleccionado.GetComponent<seleccionado>().KgSt[numeroseleccionado] = KgSt;
                seleccionado.GetComponent<seleccionado>().MfKgReal[numeroseleccionado] = cantidad;
                seleccionado.GetComponent<seleccionado>().iconosprite[numeroseleccionado] = icono;
                seleccionado.GetComponent<seleccionado>().fondosprite[numeroseleccionado] = fondo;
                PlayerPrefs.SetString("unidad", unidad);

                seleccionado.GetComponent<seleccionado>().numero += 1;
               // cantidad = int.Parse(cantidadinput.text);
            }
            else
            {


                

                biosgasTotalM3 = selecciones.GetComponent<selecciones>().totalbiogasm3;

                porcentajeSt = settings.GetComponent<cerdosengordeavanzadas>().porcentajeSt / 100;
                porcentajeSv = settings.GetComponent<cerdosengordeavanzadas>().porcentajeSv / 100;
                biogasM3KgSv = settings.GetComponent<cerdosengordeavanzadas>().biogasM3KgSv;

               
                KgSV = biosgasTotalM3 / biogasM3KgSv;
                KgSt = KgSV / porcentajeSv;
                cantidadcabezas = KgSt / porcentajeSt ;


             

                numeroseleccionado = seleccionado.GetComponent<seleccionado>().numero;
                seleccionado.GetComponent<seleccionado>().cantidaddefinitiva = cantidadcabezas;
                seleccionado.GetComponent<seleccionado>().nombres[numeroseleccionado] = tipodeproductor;
                seleccionado.GetComponent<seleccionado>().biogastotalm3[numeroseleccionado] = biosgasTotalM3;
                seleccionado.GetComponent<seleccionado>().KgSv[numeroseleccionado] = KgSV;
                seleccionado.GetComponent<seleccionado>().KgSt[numeroseleccionado] = KgSt;
                seleccionado.GetComponent<seleccionado>().MfKgReal[numeroseleccionado] = cantidad;
                seleccionado.GetComponent<seleccionado>().iconosprite[numeroseleccionado] = icono;
                seleccionado.GetComponent<seleccionado>().fondosprite[numeroseleccionado] = fondo;
                PlayerPrefs.SetString("unidad", unidad);
                seleccionado.GetComponent<seleccionado>().numero += 1;

            }









        }



    }

    public void cultivosinversos() {
        Debug.Log("ejecutando");
        if (opcionesavanzadas == false)
        {


            biosgasTotalM3 = selecciones.GetComponent<selecciones>().totalbiogasm3;
            KgSV = biosgasTotalM3 / biogasM3KgSv;
            KgSt = KgSV / porcentajeSv;
            cantidadcabezas = KgSt / porcentajeSt;



            numeroseleccionado = seleccionado.GetComponent<seleccionado>().numero;
            seleccionado.GetComponent<seleccionado>().nombres[numeroseleccionado] = tipodeproductor;
            seleccionado.GetComponent<seleccionado>().biogastotalm3[numeroseleccionado] = biosgasTotalM3;
            seleccionado.GetComponent<seleccionado>().KgSv[numeroseleccionado] = KgSV;
            seleccionado.GetComponent<seleccionado>().KgSt[numeroseleccionado] = KgSt;
            seleccionado.GetComponent<seleccionado>().MfKgReal[numeroseleccionado] = cantidad;
            seleccionado.GetComponent<seleccionado>().iconosprite[numeroseleccionado] = icono;
            seleccionado.GetComponent<seleccionado>().fondosprite[numeroseleccionado] = fondo;
            PlayerPrefs.SetString("unidad", unidad);

            seleccionado.GetComponent<seleccionado>().numero += 1;
            // cantidad = int.Parse(cantidadinput.text);
        }
        else
        {




            biosgasTotalM3 = selecciones.GetComponent<selecciones>().totalbiogasm3;

            porcentajeSt = settings.GetComponent<cerdosengordeavanzadas>().porcentajeSt / 100;
            porcentajeSv = settings.GetComponent<cerdosengordeavanzadas>().porcentajeSv / 100;
            biogasM3KgSv = settings.GetComponent<cerdosengordeavanzadas>().biogasM3KgSv;


            KgSV = biosgasTotalM3 / biogasM3KgSv;
            KgSt = KgSV / porcentajeSv;
            cantidadcabezas = KgSt / porcentajeSt;




            numeroseleccionado = seleccionado.GetComponent<seleccionado>().numero;
            seleccionado.GetComponent<seleccionado>().nombres[numeroseleccionado] = tipodeproductor;
            seleccionado.GetComponent<seleccionado>().biogastotalm3[numeroseleccionado] = biosgasTotalM3;
            seleccionado.GetComponent<seleccionado>().KgSv[numeroseleccionado] = KgSV;
            seleccionado.GetComponent<seleccionado>().KgSt[numeroseleccionado] = KgSt;
            seleccionado.GetComponent<seleccionado>().MfKgReal[numeroseleccionado] = cantidad;
            seleccionado.GetComponent<seleccionado>().iconosprite[numeroseleccionado] = icono;
            seleccionado.GetComponent<seleccionado>().fondosprite[numeroseleccionado] = fondo;
            PlayerPrefs.SetString("unidad", unidad);
            seleccionado.GetComponent<seleccionado>().numero += 1;

        }




    }
}
    
