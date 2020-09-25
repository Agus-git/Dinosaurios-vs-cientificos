using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class Intro : MonoBehaviour
{
    public GameObject[] Imagenes;
    public GameObject[] aves;
    public Reloj reloj;
    Stopwatch sw;
    bool paso1Check = true;
    bool paso2Check = true;
    int fase;
    int contador;

    void Start()
    {
        contador = 0;
        fase = 0;
        //sw = Stopwatch.StartNew();
        Imagenes[0].SetActive(true);
        Imagenes[1].SetActive(true);
    }
    void Update()
    {
        if (ManagerBanco.Puntuacion.plata == 0 && fase == 0)
        {
            fase++;
            Imagenes[4].SetActive(false);
            Imagenes[5].SetActive(false);
            Imagenes[6].SetActive(true);
        }
        if (ManagerBanco.Puntuacion.plata >= 100 && fase == 1)
        {
            Imagenes[6].SetActive(false);
            Imagenes[7].SetActive(true);
            Invoke("Cuatro", 3);
            Invoke("Cinco", 1);
            foreach (var item in aves)
            {
                item.SetActive(true);
            }
            fase++;
        }
        if (ManagerBanco.Puntuacion.plata < 100 && fase == 2)
        {
            print("Llego");
            Imagenes[8].SetActive(false);
        }
        if (contador == 2)
        {
            Imagenes[9].SetActive(true);
            Imagenes[10].SetActive(true);
            Invoke("Seis", 3);
        }
    }

    public void Recibidor()
    {
        contador++;
    }

    public void Paso1()
    {
        if (paso1Check)
        {
            Imagenes[0].SetActive(false);
            Imagenes[1].SetActive(false);
            Invoke("Uno", 1);
            Invoke("Dos", 3);
            reloj.ModoTutorial = false;
            paso1Check = false;
        }
    }

    public void Paso2()
    {
        if (paso2Check)
        {
            Imagenes[3].SetActive(false);
            Imagenes[4].SetActive(true);
            Invoke("Tres", 1);
            paso2Check = false;
        }
        else
        {
            Imagenes[4].SetActive(false);
            Imagenes[5].SetActive(false);
        }
    }

    void Uno()
    {
        Imagenes[2].SetActive(true);
    }
    void Dos()
    {
        Imagenes[2].SetActive(false);
        Imagenes[3].SetActive(true);
    }
    void Tres()
    {
        Imagenes[5].SetActive(true);
    }
    void Cuatro()
    {
        Imagenes[7].SetActive(false);
    }
    void Cinco()
    {
        Imagenes[8].SetActive(true);
    }
    void Seis()
    {
        SceneManager.LoadScene(0);
        Scene actual = SceneManager.GetActiveScene();
        SceneManager.UnloadSceneAsync(actual);
    }
}
