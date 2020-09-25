using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class Maquina : MonoBehaviour
{
    public Light light;
    Stopwatch reloj;
    System.Random ran;
    public void Awake()
    {
        reloj = Stopwatch.StartNew();
        ran = new System.Random();
    }

    void Update()
    {
        if (reloj.Elapsed.Seconds > 2)
        {
            light.color = Color.green;
            if (reloj.Elapsed.Seconds > 3)
            {
                light.color = Color.yellow;
                ManagerBanco.Puntuacion.plata += ran.Next(7,20);
                reloj.Restart();
            }
        }
    }
}
