using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    int score = 0;
    string memoria = "";

    void Start()
    { 
        var resultado = Memoria.Notas();
        for (int i = 0; i < resultado.Count; i++)
        {
            score = score + resultado[i];
            memoria = memoria + $"Nivel {i+1} = {resultado[i]}\n";
        }
        text.text = memoria + $"Puntuacion total: {score}";
    }
}
