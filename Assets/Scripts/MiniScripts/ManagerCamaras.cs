using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerCamaras : MonoBehaviour
{
    public GameObject[] camaras;
    int anterior = 0;

    void Start()
    {
        foreach (GameObject camera in camaras)
        {
            camera.SetActive(false);
            print("Ver " + camera.ToString());
        }
        camaras[0].SetActive(true);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            camaras[anterior].SetActive(false);
            camaras[0].SetActive(true);
            anterior = 0;
        }
        if(Input.GetKeyDown(KeyCode.Keypad2))
        {
            print("camara 2");
            camaras[anterior].SetActive(false);
            camaras[1].SetActive(true);
            anterior = 1;
        }
        if(Input.GetKeyDown(KeyCode.Keypad3))
        {
            camaras[anterior].SetActive(false);
            camaras[2].SetActive(true);
            anterior = 2;
        }
        if(Input.GetKeyDown(KeyCode.Keypad4))
        {
            camaras[anterior].SetActive(false);
            camaras[3].SetActive(true);
            anterior = 3;
        }
        if(Input.GetKeyDown(KeyCode.Keypad5))
        {
            camaras[anterior].SetActive(false);
            camaras[4].SetActive(true);
            anterior = 4;
        }
    }
}
