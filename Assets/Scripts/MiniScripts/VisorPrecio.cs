using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisorPrecio : MonoBehaviour
{
    public Text texto;
    public GameObject nombre;
    BotonConstruir valor;

    public void Awake()
    {
        valor = nombre.GetComponent<BotonConstruir>();
        texto.text = $"{nombre.name} ${valor.Precio}";
    }
}
