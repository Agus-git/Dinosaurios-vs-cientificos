using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonConstruir : MonoBehaviour
{
    public int Precio;
    public List<GameObject> Objetivos;
    public GameObject[] botones;
    public Material colorHijos;
    public int Eleccion;
    Image image;
    Base Chijo;
    public bool preparado;

    public void Start()
    {
        preparado = false;
        image = GetComponent<Image>();
    }

    public void Prepararse()
    {
        BotonConstruir BC;
        preparado = !preparado;
        if (preparado)
        {
            colorHijos.color = Color.green;
            image.color = Color.green;
            foreach (var item in botones)
            {
                BC = item.GetComponent<BotonConstruir>();
                if (BC.preparado)
                {
                    BC.Prepararse();
                }
            }
            foreach (var item in Objetivos)
            {
                Chijo = item.GetComponent<Base>();
                Chijo.activar(Eleccion, this, Precio);
            }
        }
        else
        {
            colorHijos.color = Color.white;
            image.color = Color.white;
            foreach (var item in Objetivos)
            {
                Chijo = item.GetComponent<Base>();
                Chijo.activar();
            }
        }

    }
}
