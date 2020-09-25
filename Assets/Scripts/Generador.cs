using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System;

public class Generador : MonoBehaviour
{
    public Transform objetivo;
    public float rango;
    public int CantidadMaxima;
    public List<int> test;
    public GameObject[] EnemigosPrimeros;
    System.Random ran;
    IAEnemy IA;


    void Start()
    {
        Invoke("Principio", 5);
        Invoke("Principio", 15);
        Invoke("Principio", 18);
        Invoke("Principio", 27);
        Invoke("Medio", 39);
        Invoke("Medio", 44);
        Invoke("Medio", 50);
        Invoke("Alto", 65);
        Invoke("Alto", 70);
        test = new List<int>();
        ran = new System.Random();
    }

    void Principio()
    {
        for (int i = 0; i < ran.Next(CantidadMaxima / 3); i++)
        {
            GameObject go = Instantiate(EnemigosPrimeros[0]);
            IA = go.GetComponent<IAEnemy>();
            go.transform.position = transform.position + transform.forward * UnityEngine.Random.Range(-rango, rango);
            go.transform.transform.Rotate(0, 0, 0);
            IA.objetivo = objetivo;
            test.Add(ran.Next(EnemigosPrimeros.Length + 1));
        }
    }

    void Medio()
    {
        for (int i = 0; i < ran.Next(CantidadMaxima / 2); i++)
        {
            GameObject go = Instantiate(EnemigosPrimeros[0]);
            IA = go.GetComponent<IAEnemy>();
            go.transform.position = transform.position + transform.forward * UnityEngine.Random.Range(-rango, rango);
            go.transform.transform.Rotate(0, 0, 0);
            IA.objetivo = objetivo;
            test.Add(ran.Next(EnemigosPrimeros.Length + 1));
        }
    }

    void Alto()
    {
        for (int i = 0; i < ran.Next(CantidadMaxima); i++)
        {
            GameObject go = Instantiate(EnemigosPrimeros[0]);
            IA = go.GetComponent<IAEnemy>();
            go.transform.position = transform.position + transform.forward * UnityEngine.Random.Range(-rango, rango) 
                + transform.right * UnityEngine.Random.Range(-rango, rango);
            go.transform.transform.Rotate(0, 0, 0);
            IA.objetivo = objetivo;
            test.Add(ran.Next(EnemigosPrimeros.Length + 1));
        }
    }

    void Update()
    {
    }
    
    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, rango);
    }
}
