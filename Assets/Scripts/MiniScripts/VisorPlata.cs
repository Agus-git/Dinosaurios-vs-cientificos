﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisorPlata : MonoBehaviour
{
    public Text text;
    void Update()
    {
        text.text =$"${ManagerBanco.Puntuacion.plata.ToString()}  ";
    }
}
