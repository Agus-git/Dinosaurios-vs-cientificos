using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minituto : MonoBehaviour
{
    public GameObject tutorial;
    void Start()
    {
        Invoke("Uno", 1);
    }
    void Uno()
    {
        tutorial.SetActive(true);
        Invoke("Dos",5);
    }
    void Dos()
    {
        tutorial.SetActive(false);
    }

}
