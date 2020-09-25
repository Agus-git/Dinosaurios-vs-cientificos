using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlujoDelMenu : MonoBehaviour
{
    public virtual int EscenaActual { get; set; }
    void Cargar(int num)
    {
        SceneManager.LoadScene(num);
        Scene actual = SceneManager.GetActiveScene();
        SceneManager.UnloadSceneAsync(actual);
    }
    public void VolverMenu()
    {
        Cargar(0);
    }
    public void Victoria()
    {
        Cargar(3);
    }
    public void Derrota()
    {
        Cargar(2);
    }
    public void Juego()
    {
        Cargar(1);
    }
    public void Tutorial()
    {
        Cargar(4);
    }
    public void SalirJuego()
    {
        Application.Quit();
    }
}
