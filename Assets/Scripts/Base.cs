using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public GameObject[] Hijos;
    bool Activo = false;
    BotonConstruir botonPadre;
    int Eleccion;
    public int precio;
    
    public void Crear()
    {
        if (Activo)
        {
            if (ManagerBanco.Puntuacion.Deposito(precio))
            {
                for (int i = 0; i < Hijos.Length; i++)
                {
                    if (i == Eleccion)
                    {
                        Hijos[i].SetActive(true);
                        botonPadre.Prepararse();
                        //print($"Mostrate {Hijos[i].name}");
                    }
                    else
                    {
                        Hijos[i].SetActive(false);
                        //print($"Escondete {Hijos[i].name}");
                    }
                }
            }
        }
    }
    
    internal void activar(int v, BotonConstruir botonConstruir, int dinero)
    {
        if (!Hijos[v].activeSelf)
        {
            botonPadre = botonConstruir;
            Eleccion = v;
            Activo = true;
            precio = dinero;
        }
    }

    internal void activar()
    {
        Activo = false;
    }


}
