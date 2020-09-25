using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerBanco : MonoBehaviour
{
    public static ManagerBanco Puntuacion;
    public int plata;
    public void Awake() { Puntuacion = this; }
    public bool Deposito(int Precio)
    {
        if (Precio <= plata)
        {
            plata = plata - Precio;
            return true;
        }
        return false;
    }
}
