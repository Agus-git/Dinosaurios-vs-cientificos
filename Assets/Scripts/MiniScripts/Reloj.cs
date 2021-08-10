using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text;
using System;

public class Reloj : MonoBehaviour
{
    public Text text;
    public bool ModoTutorial;
    public float tiempo;
    Stopwatch sw;
    public int Escena;
    void Start()
    {
        sw = Stopwatch.StartNew();
    }

    // Update is called once per frame
    void Update()
    {
        string a = sw.Elapsed.TotalMinutes.ToString();
        text.text = $"{a.Substring(0,4)}  -  {tiempo}";
        if (sw.Elapsed.TotalMinutes > tiempo)
        {
            List<int> NotasDeMemoria = Memoria.Notas();
            NotasDeMemoria.Add(ManagerBanco.Puntuacion.plata);
            Memoria.Cambiador(NotasDeMemoria);
            SceneManager.LoadScene(Escena);
            Scene actual = SceneManager.GetActiveScene();
            SceneManager.UnloadSceneAsync(actual);
        }
        if (ModoTutorial)
        {
            text.text = $"{a.Substring(0, 4)}  -  {tiempo} \n \nTiempo        Tiempo\nActual        Limite";

        }
    }
}
