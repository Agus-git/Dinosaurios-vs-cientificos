using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialAve : MonoBehaviour
{
    Vida vida;
    public Intro Controlador;
    bool listo = true;
    void Start()
    {
        vida = GetComponent<Vida>();
    }
    
    void Update()
    {
        if (vida.Salud <= 0 && listo)
        {
            Controlador.Recibidor();
            listo = false;
        }
    }
}
